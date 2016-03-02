#include <algorithm>
#include <iomanip>
#include <istream>
#include <map>
#include <numeric>
#include <ostream>
#include <set>
#include <sstream>
#include <string>
#include <utility>
#include <vector>
using namespace std;
// Powered by caide (code generator, tester, and library code inliner)


class Solution {
public:
    void solve(std::istream& in, std::ostream& out) {
		int n; in >> n;

		if (n < 3){
			out << "NO";
		}
		else {
			out << "YES" << "\n";
			if (n == 4){
				out << 1 << " * " <<  2 << " = " << 2 << endl;
				out << 2 << " * " << 3 << " = " << 6 << endl;
				out << 6 << " * " << 4 <<" = " << 24;
			}else if (n == 5){
				out << 5 << " - " << 3 << " = " << 2 << endl;
				out << 2 << " * " << 4 << " = " << 8 << endl;
				out << 8 << " * " << 3 << " = " << 24;
			}
			else {
				while (n != 4 && n != 5){
					out << n << " - " << n - 1 << " = " << 1 << "\n";
					n -= 2;
				}
				if (n == 4){
					out << 1 << " * " << 2 << " = " << 2 << "\n";
					out << 2 << " * " << 3 << " = " << 6 << "\n";
					out << 6 << " * " << 4 << " = " << 24 << "\n";
					out << 24 << " * " << 1 << " = " << 24;
				}
				else if (n == 5){
					out << 5 << " - " << 3 << " = " << 2 << "\n";
					out << 2 << " * " << 4 << " = " << 8 << "\n";
					out << 8 << " * " << 3 << " = " << 24 << "\n";
					out << 24 << " * " << 1 << " = " << 24;
				}
			}
		}
    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
