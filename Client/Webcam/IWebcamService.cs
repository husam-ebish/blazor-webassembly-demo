using System.Threading.Tasks;

namespace ConfTool.Client.Webcam
{
    public interface IWebcamService
    {
        Task StartVideo(WebcamOptions options);
        Task TakePicture();
    }
}
