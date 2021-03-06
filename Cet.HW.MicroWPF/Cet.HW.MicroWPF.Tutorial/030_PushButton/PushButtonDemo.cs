using System;
using Microsoft.SPOT;
using Cet.HW.MicroWPF.Controls;

/*
 * Copyright 2014 by Mario Vernari, Cet Electronics
 * Part of "Cet MicroWPF" (http://cetmicrowpf.codeplex.com/)
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
namespace Cet.HW.MicroWPF.Tutorial
{
    public sealed class PushButtonDemo 
        : Page
    {
        
        public static Page Create()
        {
            return new PushButtonDemo();
        }


        private PushButtonDemo()
        {
            //create a container whose children will be stacked vertically
            var container = new StackPanel();

            //create a text label
            var tb = new TextBlock();
            tb.Text="---";
            tb.Foreground = Colors.Yellow;
            tb.Font = 30;
            tb.Margin = new Thickness(30);

            //add the label as child of the stack-panel
            container.Children.Add(tb);

            //create a pushbutton
            var button = new PushButton();
            button.Text = "Click me!";
            button.Width = 150;
            button.Height = 50;
            button.Click += (s, e) =>
            {
                this._counter++;
                tb.Text = "The counter is now " + this._counter;
            };

            //add the button as child of the stack-panel
            //(also sibling of the label)
            container.Children.Add(button);

            //set the group as content of the page
            this.Content = container;
        }


        private int _counter;

    }
}
