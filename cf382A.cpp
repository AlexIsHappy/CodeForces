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
		string s; in >> s;
		int r = s.find('|');

		string d; in >> d;

		int c2 = s.length() - r - 1; int c1 = r;
		
		if ((c2 + c1 + d.length()) % 2 != 0){
			out << "Impossible";
			return;
		}


		int h = (c2 + c1 + d.length()) / 2;

		int dh1 = h - c1;
		int dh2 = h - c2;

		if (dh1 < 0 || dh2 < 0){
			out << "Impossible";
			return;
		}

		string s1 = s.substr(0, c1) + d.substr(0,dh1);
		string s2 = s.substr(r + 1, c2) + d.substr(dh1,dh2);

		out << s1 << '|' << s2;

    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
