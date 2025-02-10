using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace OniExtract2
{
    public class BSpriteInfo
    {
        public string name;
        public string textureName;
        public bool isIcon;
        public bool isInputOutput;
        public BVector2 uvMin;
        public BVector2 uvSize;
        public BVector2 realSize;
        public BVector2 pivot;

        // New relationship tracking fields
        public string parentSymbol;
        public string animationName;
        public List<string> relatedSprites;

        public BSpriteInfo(string name)
        {
            this.name = name;
            this.relatedSprites = new List<string>();
        }

        public BSpriteInfo(string name, KAnim.Build.SymbolFrameInstance? symbolFrame, Texture2D texture)
        {
            this.name = name;
            this.isIcon = name.Contains("_ui");
            this.textureName = texture.name;
            this.relatedSprites = new List<string>();

            // Track relationships
            this.parentSymbol = ""; // Default to empty string as symbol is not available in SymbolFrameInstance
            this.animationName = ""; // Default to empty string as animFile is not available in SymbolFrameInstance

            if (symbolFrame.HasValue && texture != null)
            {
                // Ensure UV coordinates are valid
                if (symbolFrame.Value.uvMin.x >= 0 && symbolFrame.Value.uvMin.y >= 0 &&
                    symbolFrame.Value.uvMax.x <= 1 && symbolFrame.Value.uvMax.y <= 1)
                {
                    uvMin = new BVector2(
                        (float)Math.Floor(symbolFrame.Value.uvMin.x * texture.width),
                        (float)Math.Floor((1 - symbolFrame.Value.uvMax.y) * texture.height)
                    );

                    uvSize = new BVector2(
                        (float)Math.Ceiling((symbolFrame.Value.uvMax.x - symbolFrame.Value.uvMin.x) * texture.width),
                        (float)Math.Ceiling((symbolFrame.Value.uvMax.y - symbolFrame.Value.uvMin.y) * texture.height)
                    );

                    var framePivot = new BVector2(
                        (symbolFrame.Value.bboxMax.x + symbolFrame.Value.bboxMin.x) / 2,
                        (symbolFrame.Value.bboxMax.y + symbolFrame.Value.bboxMin.y) / 2
                    );

                    var framePivotSize = new BVector2(
                        Math.Max(1, symbolFrame.Value.bboxMax.x - symbolFrame.Value.bboxMin.x),
                        Math.Max(1, symbolFrame.Value.bboxMax.y - symbolFrame.Value.bboxMin.y)
                    );

                    var xy = new BVector2(
                        framePivot.x - framePivotSize.x / 2f,
                        framePivot.y - framePivotSize.y / 2f
                    );

                    pivot = new BVector2(
                        0 - xy.x / framePivotSize.x,
                        1 + xy.y / framePivotSize.y
                    );

                    realSize = new BVector2(
                        Math.Max(1, framePivotSize.x / 2),
                        Math.Max(1, framePivotSize.y / 2)
                    );
                }
                else
                {
                    Debug.LogWarning($"Invalid UV coordinates for sprite {name} in texture {texture.name}");
                    // Set fallback values
                    uvMin = new BVector2(0, 0);
                    uvSize = new BVector2(texture.width, texture.height);
                    realSize = new BVector2(texture.width, texture.height);
                    pivot = new BVector2(0.5f, 0.5f);
                }
            }
        }

        public BSpriteInfo(Sprite sprite, string textureName, Texture2D texture)
        {
            name = sprite.name;
            this.textureName = textureName;
            this.relatedSprites = new List<string>();
            isIcon = true;

            if (texture != null)
            {
                uvMin = new BVector2(
                    (float)Math.Floor(sprite.textureRect.x),
                    (float)Math.Floor(texture.height - sprite.textureRect.y - sprite.textureRect.height)
                );
                uvSize = new BVector2(
                    (float)Math.Ceiling(sprite.textureRect.width),
                    (float)Math.Ceiling(sprite.textureRect.height)
                );
                realSize = new BVector2(uvSize.x, uvSize.y);
                pivot = new BVector2(
                    sprite.pivot.x / uvSize.x,
                    sprite.pivot.y / uvSize.y
                );
            }
        }

        public void AddRelatedSprite(string spriteName)
        {
            if (!relatedSprites.Contains(spriteName))
            {
                relatedSprites.Add(spriteName);
            }
        }
    }
}
