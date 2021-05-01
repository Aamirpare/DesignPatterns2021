using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics.Sessional1.Question2
{
    public class Benefits
    {

    }
    public abstract class Employee
    {
        Benefits Benefits { set; get; }
    }
    public class Faculty : Employee
    {

    }
    public class Coordinator : Employee
    {
        void AssginCourse(Faculty faculty)
        {
            
        }
    }
}

namespace OOPBasics.Sessional1.Question4
{
    public class VideoEditor
    {
        static VideoEditor EditorInstance { get; set; } = new VideoEditor();
        public string VideoUrl { get; set; }

        public VideoEditor GetInstance()
        {
            return EditorInstance;
        }
        private VideoEditor()
        {
            VideoUrl = "d:/videos/lecture-1.mp4";
        }
        public void ScaleVideo()
        {
            //Video Scaling Logic
        }
        public void CreateThumbnail()
        {
            //Video thumbnail Logic
        }
    }

}