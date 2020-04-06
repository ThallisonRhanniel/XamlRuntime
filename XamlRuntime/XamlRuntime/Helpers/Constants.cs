using System;
using System.Collections.Generic;
using System.Text;

namespace XamlRuntime.Helpers
{
    public static class RuntimePage
    {
        public const string Header =
            @"<?xml version='1.0' encoding='utf-8' ?>
             <ContentPage xmlns='http://xamarin.com/schemas/2014/forms'
             xmlns:x='http://schemas.microsoft.com/winfx/2009/xaml'
             xmlns:d='http://xamarin.com/schemas/2014/forms/design'
             xmlns:mc='http://schemas.openxmlformats.org/markup-compatibility/2006'
             Title='Thallison'    
             mc:Ignorable='d'  >

            <ScrollView>
                <StackLayout x:Name='StackLayout1' HorizontalOptions='FillAndExpand' VerticalOptions='FillAndExpand' >";


        public const string Label = 
            @"<Label Text='Welcome to Xamarin.Forms!'
             x:Name='lblWelcome' VerticalOptions='CenterAndExpand' 
             HorizontalOptions='CenterAndExpand' />";


        public static string StartLabel = 
            @"<Label Text='Welcome to Xamarin.Forms!'
               x:Name='";

        public static string EndLabel = 
            @"' VerticalOptions='CenterAndExpand' 
              HorizontalOptions='CenterAndExpand' />";



        public const string Footer = 
            @"</StackLayout>
                </ScrollView>
                    </ContentPage>";
    }
}
