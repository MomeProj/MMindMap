using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMindmap
{
	/*
	  ISO paper sizes in portrait view(with rounded inch values)
	  Format A series[5]                 B series[6]                 C series[7]
	  Size  mm × mm      in × in        mm × mm       in × in       mm × mm      in × in
	  0    841 × 1189  33.10 × 46.80  1000 × 1414  39.40 × 55.70  917 × 1297  36.10 × 51.10
	  1    594 ×  841  23.40 × 33.10   707 × 1000  27.80 × 39.40  648 ×  917  25.50 × 36.10
	  2    420 ×  594  16.50 × 23.40   500 ×  707  19.70 × 27.80  458 ×  648  18.00 × 25.50
	  3    297 ×  420  11.70 × 16.50   353 ×  500  13.90 × 19.70  324 ×  458  12.80 × 18.00
	  4    210 ×  297   8.27 × 11.70   250 ×  353   9.84 × 13.90  229 ×  324   9.02 × 12.80
	  5    148 ×  210   5.83 ×  8.27   176 ×  250   6.93 ×  9.84  162 ×  229   6.38 ×  9.02
	  6    105 ×  148   4.13 ×  5.83   125 ×  176   4.92 ×  6.93  114 ×  162   4.49 ×  6.38
	  7     74 ×  105   2.91 ×  4.13    88 ×  125   3.46 ×  4.92   81 ×  114   3.19 ×  4.49
	  8     52 ×   74   2.05 ×  2.91    62 ×   88   2.44 ×  3.46   57 ×   81   2.24 ×  3.19
	  9     37 ×   52   1.46 ×  2.05    44 ×   62   1.73 ×  2.44   40 ×   57   1.57 ×  2.24
	  10    26 ×   37   1.02 ×  1.46    31 ×   44   1.22 ×  1.73   28 ×   40   1.10 ×  1.57

	  https://en.wikipedia.org/wiki/Paper_size
	*/
	class ISOPaperSizeDTO
	{
		private Dictionary<string, List<Dictionary<string, Decimal>>> isoPaperSize = new Dictionary<string, List<Dictionary<string, decimal>>>();
		public ISOPaperSizeDTO(int dpi = 72)
		{
			isoPaperSize.Add("A Series", new List<Dictionary<string, decimal>>()
			{
				new Dictionary<string, decimal> {{ "width", 841 }, { "Height", 1189 }},
				new Dictionary<string, decimal> {{ "width", 594 }, { "Height",  841 } },
				new Dictionary<string, decimal> {{ "width", 420 }, { "Height",  594 } },
				new Dictionary<string, decimal> {{ "width", 297 }, { "Height",  420 } },
				new Dictionary<string, decimal> {{ "width", 210 }, { "Height",  297 } },
				new Dictionary<string, decimal> {{ "width", 148 }, { "Height",  210 } },
				new Dictionary<string, decimal> {{ "width", 105 }, { "Height",  148 } },
				new Dictionary<string, decimal> {{ "width",  74 }, { "Height",  105 } },
				new Dictionary<string, decimal> {{ "width",  52 }, { "Height",   74 } },
				new Dictionary<string, decimal> {{ "width",  37 }, { "Height",   52 } },
				new Dictionary<string, decimal> {{ "width",  26 }, { "Height",   37 } }
			});
			isoPaperSize.Add("B Series", new List<Dictionary<string, decimal>>()
			{
				new Dictionary<string, decimal> {{ "width", 1000 }, { "Height", 1414 } },
				new Dictionary<string, decimal> {{ "width",  707 }, { "Height", 1000 } },
				new Dictionary<string, decimal> {{ "width",  500 }, { "Height",  707 } },
				new Dictionary<string, decimal> {{ "width",  353 }, { "Height",  500 } },
				new Dictionary<string, decimal> {{ "width",  250 }, { "Height",  353 } },
				new Dictionary<string, decimal> {{ "width",  176 }, { "Height",  250 } },
				new Dictionary<string, decimal> {{ "width",  125 }, { "Height",  176 } },
				new Dictionary<string, decimal> {{ "width",   88 }, { "Height",  125 } },
				new Dictionary<string, decimal> {{ "width",   62 }, { "Height",   88 } },
				new Dictionary<string, decimal> {{ "width",   44 }, { "Height",   62 } },
				new Dictionary<string, decimal> {{ "width",   31 }, { "Height",   44 } }
			});
			isoPaperSize.Add("C Series", new List<Dictionary<string, decimal>>()
			{
				new Dictionary<string, decimal> {{ "width", 917 }, { "Height", 1297 } },
				new Dictionary<string, decimal> {{ "width", 648 }, { "Height", 917  } },
				new Dictionary<string, decimal> {{ "width", 458 }, { "Height", 648  } },
				new Dictionary<string, decimal> {{ "width", 324 }, { "Height", 458  } },
				new Dictionary<string, decimal> {{ "width", 229 }, { "Height", 324  } },
				new Dictionary<string, decimal> {{ "width", 162 }, { "Height", 229  } },
				new Dictionary<string, decimal> {{ "width", 114 }, { "Height", 162  } },
				new Dictionary<string, decimal> {{ "width",  81 }, { "Height", 114  } },
				new Dictionary<string, decimal> {{ "width",  57 }, { "Height", 81   } },
				new Dictionary<string, decimal> {{ "width",  40 }, { "Height", 57   } },
				new Dictionary<string, decimal> {{ "width",  28 }, { "Height", 40   } }
			});
		}
	}
}
