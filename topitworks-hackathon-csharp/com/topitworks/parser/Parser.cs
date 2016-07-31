using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace topitworks_hackathon_csharp.com.topitworks.parser
{
    public interface Parser
    {
        String parse(string resumeFilePath);
    }
}
