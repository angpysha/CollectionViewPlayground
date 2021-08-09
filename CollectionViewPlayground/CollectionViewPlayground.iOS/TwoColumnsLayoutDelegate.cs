using UIKit;
using Foundation;


namespace CollectionViewPlayground.iOS
{
    public interface TwoColumnsLayoutDelegate
    {
        float GetHeight(UICollectionView collectionView, NSIndexPath indexPath, float width);
    }
}