using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using static OniExtract2.Patches;

namespace OniExtract2
{
    public class BElement
    {
        public string name;
        public string id;
        public int tag;
        public List<string> oreTags;
        public int buildMenuSort;

        private static string GetLogFilePath()
        {
            string databaseLocation = Path.Combine(Util.RootFolder(), "export", "database");
            if (!Directory.Exists(databaseLocation))
                Directory.CreateDirectory(databaseLocation);
            return Path.Combine(databaseLocation, "element_extraction_log.txt");
        }

        public static void LogToFile(string message)
        {
            try
            {
                string logMessage = $"[{System.DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}\n";
                File.AppendAllText(GetLogFilePath(), logMessage);
            }
            catch (Exception ex)
            {
                Debug.Log("ERROR writing to log file: " + ex.Message);
            }
        }

        public static void StartNewExtractionLog()
        {
            try
            {
                string logFilePath = GetLogFilePath();
                File.WriteAllText(logFilePath, $"ELEMENT EXTRACTION LOG - Started at {System.DateTime.Now:yyyy-MM-dd HH:mm:ss}\n");
                File.AppendAllText(logFilePath, "=================================================================\n");
                Debug.Log("Element extraction log file created: " + logFilePath);
            }
            catch (Exception ex)
            {
                Debug.Log("ERROR creating log file: " + ex.Message);
            }
        }

        public int color;
        public int conduitColor;
        public int uiColor;

        public string icon;
        private string textureName;
        private string kanimPrefix;

        public BElement(Element e, Export export)
        {

            this.name = e.name;
            this.id = e.id.ToString();
            this.tag = e.tag.GetHash();
            Debug.Log("*****************");
            Debug.Log("PROCESSING ELEMENT: " + e.name + " (ID: " + e.id.ToString() + ")");
            LogToFile("==========================================");
            LogToFile("PROCESSING ELEMENT: " + e.name + " (ID: " + e.id.ToString() + ")");
            //int startIndex = this.name.IndexOf("\">");
            //if (startIndex != -1) this.name = this.name.Substring(startIndex + 2);
            //int endIndex = this.name.IndexOf("</");
            //if (endIndex != -1) this.name = this.name.Substring(0, endIndex);

            //element.materialCategory = e.materialCategory.Name;
            this.buildMenuSort = e.buildMenuSort;

            this.oreTags = new List<string>();
            foreach (var t in e.oreTags)
                this.oreTags.Add(t.Name);

            var substance = e.substance;

            this.color = (substance.colour.r << 16) | (substance.colour.g << 8) | (substance.colour.b << 0);
            this.conduitColor = (substance.conduitColour.r << 16) | (substance.conduitColour.g << 8) | (substance.conduitColour.b << 0);
            this.uiColor = (substance.uiColour.r << 16) | (substance.uiColour.g << 8) | (substance.uiColour.b << 0);

            export.elements.Add(this);

            if (this.oreTags.Contains("Gas") || this.oreTags.Contains("Liquid")) return;

            var data = substance.anim.GetData();

            if (data.build.textureCount > 0)
            {
                textureName = data.build.GetTexture(0).name;
                // Note: Element UI textures are now saved with proper sprite names in the UI processing loop below
                // if (OniExtract_Game_OnPrefabInit.saveSubstanceTexture) OniExtract_Game_OnPrefabInit.SaveTexture(textureName, data.build.GetTexture(0));
            }

            kanimPrefix = e.id.ToString() + "_";
            for (int indexGetAnim = 0; indexGetAnim < data.animCount; ++indexGetAnim)
            {
                var anim = data.GetAnim(indexGetAnim);
                Debug.Log(anim.name);

                bool isUi = anim.name.Equals("ui");
                if (!isUi) continue;

                var animationName = kanimPrefix + anim.name;
                Debug.Log("PROCESSING ELEMENT UI SPRITE: " + animationName + " for element: " + this.name);
                LogToFile("PROCESSING ELEMENT UI SPRITE: " + animationName + " for element: " + this.name);

                // var firstFrame = anim.GetFrame(anim.animFile.animBatchTag, 0);
                var firstFrame = new KAnim.Anim.Frame();
                anim.TryGetFrame(anim.animFile.animBatchTag, 0, out firstFrame);

                if (firstFrame.numElements == 0)
                {
                    Debug.Log("0 element for : " + animationName);
                    continue;
                }

                if (firstFrame.numElements == 1)
                {
                    var newSpriteModifier = new BSpriteModifier();
                    export.spriteModifiers.Add(newSpriteModifier);
                    newSpriteModifier.name = animationName;

                    var indexElement = firstFrame.firstElementIdx + 0;
                    //var frameElement = data.GetAnimFrameElement(indexElement);
                    KBatchGroupData batchGroupData = KAnimBatchManager.Instance().GetBatchGroupData(data.animBatchTag);
                    if(batchGroupData == null)
                    {
                        Debug.Log("SKIPPING ELEMENT UI SPRITE - batchGroupData is null for: " + animationName + " (tag: " + data.animBatchTag + ")");
                        LogToFile("SKIPPING ELEMENT UI SPRITE - batchGroupData is null for: " + animationName + " (tag: " + data.animBatchTag + ")");
                        continue;
                    }
                    var frameElement = batchGroupData.GetFrameElement(indexElement);

                    BBuildingFinal.LoadSpriteModifier(kanimPrefix, newSpriteModifier, frameElement);
                    BBuildingFinal.AddSpriteInfo(export, newSpriteModifier, data, frameElement, false);

                    icon = newSpriteModifier.spriteInfoName;
                    
                    // Save texture with the same name as the sprite info to avoid naming mismatch
                    if (OniExtract_Game_OnPrefabInit.saveSubstanceTexture) 
                    {
                        string unityTextureName = data.build.GetTexture(0).name;
                        LogToFile("TEXTURE NAMING: Unity name='" + unityTextureName + "' -> Sprite name='" + icon + "' for element: " + this.name);
                        OniExtract_Game_OnPrefabInit.SaveTexture(icon, data.build.GetTexture(0));
                        LogToFile("TEXTURE SAVED: " + icon + ".png for element: " + this.name);
                    }
                    
                    Debug.Log("SUCCESS: Created UI sprite for element: " + this.name + " -> " + icon);
                    LogToFile("SUCCESS: Created UI sprite for element: " + this.name + " -> " + icon);

                    continue;
                }
                else if (firstFrame.numElements > 1) Debug.Log("More than 2 elements : " + this.name);
            }

            
        }
    }
}
