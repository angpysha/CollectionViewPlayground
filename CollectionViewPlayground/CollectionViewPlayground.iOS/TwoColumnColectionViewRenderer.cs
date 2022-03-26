using CollectionViewPlayground;
using CollectionViewPlayground.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(TwoColumnCollectionView),typeof(TwoColumnCollectionViewRenderer))]
namespace CollectionViewPlayground.iOS
{
    public class TwoColumnCollectionViewRenderer : GroupableItemsViewRenderer<GroupableItemsView, ExtendedCOllectionViewController>
    {
        private UICollectionViewLayout _layout;
        protected override ExtendedCOllectionViewController CreateController(GroupableItemsView itemsView,
            ItemsViewLayout layout) => new ExtendedCOllectionViewController(itemsView, layout);

        protected new TwoColumnsCollectionViewLayout SelectLayoutNew()
        {
            return new TwoColumnsCollectionViewLayout();
        }


        //protected override ItemsViewLayout SelectLayout()
        //{
        //    var itemSizingStrategy = ItemsView.ItemSizingStrategy;
        //    var itemsLayout = ItemsView.ItemsLayout;

        //    return new EmptyLayout(new LinearItemsLayout(ItemsLayoutOrientation.Vertical), itemSizingStrategy);
        //}

        protected override void OnElementChanged(ElementChangedEventArgs<GroupableItemsView> e)
        {
            base.UpdateLayout();
            base.OnElementChanged(e);
            
            UpdateLayout();
            
            // SetUpNewElement(e.NewElement);
            // var ctrl = Controller;
            // var iii = 0;
        }

        

        protected override void UpdateLayout()
        {
          //  base.UpdateLayout();
           // this.Layout
         //  _layout = SelectLayoutNew();

           //
         //   Controller?.UpdateLayoutEx(_layout);
        }
    }
}