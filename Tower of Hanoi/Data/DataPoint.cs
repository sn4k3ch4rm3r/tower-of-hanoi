using System;

namespace TowerOfHanoi.Data
{
    public struct DataPoint
    {
        public DataPoint(User user, TimeSpan time)
        {
            User = user;
            Time = time;
        }

        public User User { get; }
        public TimeSpan Time { get; }
    }
}