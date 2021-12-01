using System;
using System.Collections.Generic;
using System.Text;

namespace work_8
{
    class SmartPhone : Phone
    {
        protected int CountFinger { get; set; }
        protected int CountCameras;
        public SmartPhone(string number, string number2, int width, int height, double size_screen, ConsoleColor color, int count_finger, int count_cameras)
            :base(number, number2, width, height, size_screen, color)
        {
            this.CountFinger = count_finger;
            this.CountCameras = count_cameras;
        }

        public void create_photo(int n_cam)
        {
            if(n_cam > this.CountCameras)
            {
                Console.WriteLine("You have only {0} cameras", this.CountCameras);
            }
            else
            {
                Console.WriteLine("You made a photo.");
            }
        }

        public void create_movie(int n_cam)
        {
            if (n_cam > this.CountCameras)
            {
                Console.WriteLine("You have only {0} cameras", this.CountCameras);
            }
            else
            {
                Console.WriteLine("You made a movie.");
            }
        }
    }
}
