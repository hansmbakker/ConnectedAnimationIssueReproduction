using ConnectedAnimationIssue.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace ConnectedAnimationIssue.Controls
{
    public sealed partial class GithubIssueSummary : UserControl
    {
        public GithubIssueSummary()
        {
            this.InitializeComponent();
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(GithubIssueSummary), new PropertyMetadata(null));
        
        public GithubUser Creator
        {
            get { return (GithubUser)GetValue(CreatorProperty); }
            set { SetValue(CreatorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Creator.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CreatorProperty =
            DependencyProperty.Register("Creator", typeof(GithubUser), typeof(GithubIssueSummary), new PropertyMetadata(null));



    }
}
