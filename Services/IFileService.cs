using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slidex.Services
{

    public interface IFileService
    {
        String Path { get; }
        bool OpenFileDialog(String defaultExt, String filter);
        bool OpenFileDialog(String defaultExt, String filter, String initDir, String title);
        bool SaveFileDialog(String defaultExt, String filter);
        bool SaveFileDialog(String defaultExt, String filter, String initDir, String title);
        List<String> RecentFiles { get; }
    }
}
