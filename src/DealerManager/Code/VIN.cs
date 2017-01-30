using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerManager.Code
{
    /* VIN Number Standards
     * 
     * Digits       Description
     * ========================================================
     * ISO-3779
     * --------
     * 1-3          World Manufacturer Identifier
     * 4-9          VDS
     * 10-17        VIS
     * --------
     * EU+USA 1
     * --------
     * 1-3          World Manufacturer Identifier 
     * 4-8          Vehicle Attributes
     * 9            Check Digit
     * 10           Model Year
     * 11           Plant Code
     * 12-17        Sequential NUmber
     * --------
     * EU+USA 2
     * --------
     * 1-2          World Manufacturer Identifier
     * 3            Digit '9'
     * 4-8          Vehicle Attributes
     * 9            Check Digit
     * 10           Model Year
     * 11           Plant Code
     * 12-14        Manufacturer Identifier
     * 15-17        Sequential Number
     * --------
     * TODO: Settings for VIN Number standards
     * TODO: VIN Decoding
     * 
     */


    class VIN
    {

    }
}
