using Android.Content;
using AndroidX.RecyclerView.Widget;
using CollectionViewPlayground;
using CollectionViewPlayground.Android;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(TwoColumnCollectionView),typeof(TwoColumnsCollectionViewRenderer))]
namespace CollectionViewPlayground.Android
{
    public class TwoColumnsCollectionViewRenderer : CollectionViewRenderer
    {
        public TwoColumnsCollectionViewRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<ItemsView> elementChangedEvent)
        {
            base.OnElementChanged(elementChangedEvent);
            this.SetLayoutManager(new StaggeredGridLayoutManager(2, StaggeredGridLayoutManager.Vertical));
        }
    }
}