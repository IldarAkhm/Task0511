using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuMak
{
    internal class Song
    {
        string name;
        string author;
        readonly Song prev;
        public void SetName()
        {
            Console.WriteLine("Enter name of song");
            name = Console.ReadLine();
        }
        public void SetAuthor()
        {
            Console.WriteLine("Enter song`s author");
            author = Console.ReadLine();
        }
        public void SetPrev(Song song)
        {
            prev.name = song.name;
            prev.author = song.author;
        }
        public static string Title(Song song)
        {
            return $"{song.name} {song.author}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Song)
            {
                if ($"{this.name} {this.author}" == Song.Title(obj as Song))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
