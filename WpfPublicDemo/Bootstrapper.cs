﻿using System;
using Stylet;
using StyletIoC;
using WpfPublicDemo.Pages;

namespace WpfPublicDemo
{
    public class Bootstrapper : Bootstrapper<ShellViewModel>
    {
        protected override void ConfigureIoC(IStyletIoCBuilder builder)
        {
            // Configure the IoC container in here
        }

        protected override void Configure()
        {
            // Perform any other configuration before the application starts
        }
    }
}
