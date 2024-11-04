using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevsPark.MVVM.ViewModels;

namespace DevsPark.MVVM.Pages;

public partial class FeaturedView : ContentPage
{
    public FeaturedView(FeaturedViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}