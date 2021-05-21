using System.Collections.Generic;

namespace HW5
{
    public interface IDeveloper
    {
        string Tool { get; set; }
        void Create(List<IDeveloper> arr);
        void Destroy(List<IDeveloper> arr);
    }
}
