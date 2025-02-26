﻿using HarmonyLib;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace SolastaModApi
{
    public class GuiPresentationBuilder
    {
        private readonly GuiPresentation guiPresentation;

        public GuiPresentationBuilder(string description, string title)
        {
            guiPresentation = new GuiPresentation
            {
                Description = description,
                Title = title
            };

            Traverse.Create(guiPresentation).Field("spriteReference").SetValue(new AssetReferenceSprite(""));
        }

        public void SetColor(Color color)
        {
            Traverse.Create(guiPresentation).Field("color").SetValue(color);
        }

        public void SetSortOrder(int sortOrder)
        {
            Traverse.Create(guiPresentation).Field("sortOrder").SetValue(sortOrder);
        }

        public void SetSpriteReference(AssetReferenceSprite sprite)
        {
            Traverse.Create(guiPresentation).Field("spriteReference").SetValue(sprite);
        }

        public GuiPresentation Build()
        {
            return guiPresentation;
        }
    }
}
