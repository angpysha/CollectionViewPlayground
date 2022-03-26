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


        public ExtendedCOllectionViewController(GroupableItemsView groupableItemsView, ItemsViewLayout layout)
            : base(groupableItemsView, layout)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //View.BackgroundColor = UIColor.Red;
            var layout = new TwoColumnsCollectionViewLayout();


            layout.Delegate = this;
            layout.SectionInsetReference = UICollectionViewFlowLayoutSectionInsetReference.ContentInset; // .fromContentInset is default
         //   layout.EstimatedItemSize = UICollectionViewFlowLayout.AutomaticSize;
            layout.MinimumInteritemSpacing = 10;
            layout.MinimumLineSpacing = 10;
            layout.SectionInset = new UIEdgeInsets(top: 10, left: 10, bottom: 10, right: 10);
            layout.HeaderReferenceSize = new CGSize(width: 0, height: 40);


            CollectionView.CollectionViewLayout = layout;
            CollectionView.RegisterClassForCell(typeof(TwoColumnViewCollectionViewCell), "TwoColumnsCell");

        }

        protected override UICollectionViewDelegateFlowLayout CreateDelegator()
        {
            return new TwoColumsCollectionViewDelegator(ItemsViewLayout, this);
        }

        public override void ViewWillAppear(bool animated)
        {
            //Ignore default 
        }

        public override void ViewWillLayoutSubviews()
        {
            //Ignore default 
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
            (layout as TwoColumnsCollectionViewLayout).EstimatedItemSize = UICollectionViewFlowLayout.AutomaticSize;
            CollectionView.ContentInsetAdjustmentBehavior = UIScrollViewContentInsetAdjustmentBehavior.Always;
            //layout.Es
            CollectionView.SetCollectionViewLayout(layout, false);
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var binding = (ItemsView.ItemsSource as IEnumerable<object>).ElementAt((int)indexPath.Item);

            var cell = CollectionView.DequeueReusableCell("TwoColumnsCell", indexPath) as TwoColumnViewCollectionViewCell;
            var template = ItemsView.ItemTemplate.SelectDataTemplate(binding, ItemsView);
            var item = template.CreateContent() as View;
            item.BindingContext = binding;
            var renderer = Platform.GetRenderer(item);
            if (renderer == null)
            {
                Platform.SetRenderer(item, Platform.CreateRenderer(item));
                renderer = Platform.GetRenderer(item);
            }

            var measured = item.Measure(cell.Frame.Width, double.MaxValue);
            var height = measured.Request.Height > 0 ? measured.Request.Height : measured.Minimum.Height; ;

            item.Layout(new Rectangle(0, 0, cell.Frame.Width, height));


            var nativeVIew = renderer.NativeView;
            nativeVIew.Frame = new CGRect(0, 0, cell.Frame.Width, height);

            cell.ContentView.AddSubview(nativeVIew);
            var clFrame = cell.Frame;
            clFrame.Width = nativeVIew.Frame.Width;
            clFrame.Height = nativeVIew.Frame.Height;
            cell.Frame = clFrame;

            // cell.Frame = nativeVIew.Frame;
            //CollectionView.CollectionViewLayout.InvalidateLayout();
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
            var size = base.GetSizeForItem(collectionView, layout, indexPath);
            return size;
        }
    }


}