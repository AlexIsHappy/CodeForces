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
		int x, y; in >> x >> y;

		if (x > 0 && y > 0){
			out << "0 " << x + y << " " << x + y << " 0";
		}
		else if (x < 0 && y < 0){
			out << (x + y) << " 0 0 " << (x + y);
		}
		else if (x > 0 && y < 0){
			out << "0 " << -(abs(x) + abs(y)) << " " << (abs(x) + abs(y)) << " 0";
		}
		else if (x < 0 && y > 0){
			out << -(abs(x) + abs(y)) << " 0 0 " << abs(x) + abs(y);
		}
    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
