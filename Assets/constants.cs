using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets {
    class Constants {
        public static string BULLET_TAG = "Bullet";
        public static string SPIDER_TAG = "Spider";
        public static string HEALTHY_TAG = "Healthy";
        public static string UNHEALTHY_TAG = "Unhealthy";

        public static int PLAYER_COLLISION_HEALTHY_POINTS = 50;
        public static int BULLET_COLLISION_HEALTHY_POINTS = 0;
        public static int PLAYER_COLLISION_UNHEALTHY_POINTS = -50;
        public static int BULLET_COLLISION_UNHEALTHY_POINTS = 10;
        public static int PLAYER_COLLISION_SPIDER_POINTS = -50;
        public static int BULLET_COLLISION_SPIDER_POINTS = 10;
    }
}
