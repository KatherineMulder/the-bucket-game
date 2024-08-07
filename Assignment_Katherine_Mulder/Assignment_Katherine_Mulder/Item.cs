﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Katherine_Mulder
{
    internal class Item
    {
        //properties
        static public int boundaryW = 10;//Use "Static" keyword to define shared info among objects
        static public int boundaryH = 10;//Use "Static" keyword to define shared info among objects

        public int width;
        public int height;

        public SolidBrush color;
        public Vector2 topLeft;
        public Vector2 velocity;

        //Constructors
        public Item(int width, int height,
                   SolidBrush color, Vector2 location)
        {
            this.width = width;
            this.height = height;

            this.color = color;
            this.topLeft = location;

            Random rand = new Random();
            this.velocity = new Vector2(rand.Next(4) + 1, rand.Next(5));
        }

        //Methods
        virtual public void draw(Graphics canvas)
        {
            
        }

        public void move()
        {
            //Check if the circle reaches to any bound? 
            //Detect the horizontal borders
            if (this.topLeft.Y < 0)
            {
                //Top border
                velocity.Y = -velocity.Y;
                topLeft.Y = 0;
            }
            else if (topLeft.Y + height > boundaryH)
            {
                //Bottom border
                velocity.Y = -velocity.Y;
                topLeft.Y = boundaryH - height;
            }

            //Detect the vertical borders
            if (topLeft.X < 0)
            {
                //Left border
                velocity.X = -velocity.X;
                topLeft.X = 0;
            }
            else if (topLeft.X + width > boundaryW)
            {
                //Right border
                velocity.X = -velocity.X;
                topLeft.X = boundaryW - width;
            }

            //Move the shape 
            this.topLeft = this.topLeft + this.velocity;


        }

     }
}
