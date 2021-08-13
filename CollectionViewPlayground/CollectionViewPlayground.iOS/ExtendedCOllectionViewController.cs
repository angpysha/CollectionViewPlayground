using System.Collections.Generic;
using System.Linq;
using CoreGraphics;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Platform.iOS;

namespace CollectionViewPlayground.iOS
{
    public class ExtendedCOllectionViewController : GroupableItemsViewController<GroupableItemsView>, TwoColumnsLayoutDelegate
    {
        
        
        public ExtendedCOllectionViewController(GroupableItemsView groupableItemsView, ItemsViewLayout layout) : base(groupableItemsView, layout)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            
            CollectionView.RegisterClassForCell(typeof(TwoColumnViewCollectionViewCell),"TwoColumnsCell");
        }

        protected override UICollectionViewDelegateFlowLayout CreateDelegator()
        {
            return new TwoColumsCollectionViewDelegator(ItemsViewLayout,this);
        }

        public float GetHeight(UICollectionView collectionView, NSIndexPath indexPath, float width)
        {
            var cl = ItemsView.ItemTemplate.CreateContent() as View;
            var binding = (ItemsView.ItemsSource as IEnumerable<object>).ElementAt((int)indexPath.Item);
            cl.BindingContext = binding;
            var measured = cl.Measure(width, double.MaxValue);
            var height = measured.Request.Height > 0 ? measured.Request.Height : measured.Minimum.Height; ;
            return (float)height;
        }

        
        public void UpdateLayoutEx(UICollectionViewLayout layout)
        {
            if (CollectionView.CollectionViewLayout == layout)
                return;
            (layout as TwoColumnsCollectionViewLayout).Delegate = this;
        
            CollectionView.SetCollectionViewLayout(layout,false);
 
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var binding = (ItemsView.ItemsSource as IEnumerable<object>).ElementAt((int)indexPath.Item);

            var cell = CollectionView.DequeueReusableCell("TwoColumnsCell", indexPath) as TwoColumnViewCollectionViewCell;
            var template = ItemsView.ItemTemplate.SelectDataTemplate(binding, ItemsView);
            var item = template.CreateContent() as View;
            item.BindingContext = binding;
            item.Layout(new Rectangle(0, 0, cell.Frame.Width, cell.Frame.Height));
            var renderer = Platform.GetRenderer(item);
            if (renderer == null)
            {
                Platform.SetRenderer(item,Platform.CreateRenderer(item));
                renderer = Platform.GetRenderer(item);
            }

            var nativeVIew = renderer.NativeView;
            nativeVIew.Frame = new CGRect(0,0, cell.Frame.Width, cell.Frame.Height);
            
            cell.ContentView.AddSubview(nativeVIew);
            return cell;
        }
    }

    public class
        TwoColumsCollectionViewDelegator : GroupableItemsViewDelegator<GroupableItemsView,
            ExtendedCOllectionViewController>
    {
        public TwoColumsCollectionViewDelegator(ItemsViewLayout itemsViewLayout, ExtendedCOllectionViewController itemsViewController) : base(itemsViewLayout, itemsViewController)
        {
        }

        public override CGSize GetSizeForItem(UICollectionView collectionView, UICollectionViewLayout layout, NSIndexPath indexPath)
        {
            var size =  base.GetSizeForItem(collectionView, layout, indexPath);
            return size;
        }
    }


}