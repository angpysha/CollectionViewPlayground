using System;
using CoreGraphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace CollectionViewPlayground.iOS
{
    public class EmptyLayout : ItemsViewLayout
    {
        public EmptyLayout(LinearItemsLayout itemsLayout, ItemSizingStrategy itemSizingStrategy) : base(itemsLayout, itemSizingStrategy)
        {

        }

        public override void ConstrainTo(CGSize size)
        {
            
        }

        public override bool ShouldInvalidateLayoutForBoundsChange(CGRect newBounds)
        {
            return true;
        }
    }
}
