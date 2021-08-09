using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CollectionViewPlayground
{
    public class Item
    {
        public double Height { get; set; }
        public Color BackgroundColor { get; set; }
    }
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            CollectionView.ItemsSource = new List<Item>()
            {
                new Item()
                {
                    Height = 120,
                    BackgroundColor = Color.Aqua
                },
                new Item()
                {
                    Height = 80,
                    BackgroundColor = Color.Bisque
                },
                new Item()
                {
                    Height = 40,
                    BackgroundColor = Color.Blue
                },
                new Item()
                {
                    Height = 150,
                    BackgroundColor = Color.Chartreuse
                },
                new Item()
                {
                    Height = 65,
                    BackgroundColor = Color.Chocolate
                },
                new Item()
                {
                    Height = 200,
                    BackgroundColor = Color.Fuchsia
                },
                new Item()
                {
                    Height = 144,
                    BackgroundColor = Color.Gold
                },
                new Item()
                {
                    Height = 80,
                    BackgroundColor = Color.Gray
                },
                new Item()
                {
                    Height = 25,
                    BackgroundColor = Color.Green
                },
                new Item()
                {
                    Height = 180,
                    BackgroundColor = Color.Orange
                },
                new Item()
                {
                    Height = 212,
                    BackgroundColor = Color.Olive
                },
                new Item()
                {
                    Height = 55,
                    BackgroundColor = Color.DarkBlue
                },
                new Item()
                {
                    Height = 350,
                    BackgroundColor = Color.Yellow
                },
                new Item()
                {
                    Height = 168,
                    BackgroundColor = Color.Maroon
                },
            };
        }
    }
}