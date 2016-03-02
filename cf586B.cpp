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

		vector<int> f;  int sf = 0;
		vector<int> s;  int ss = 0;

		vector<int> p; int sp = 0;

		for (int i = 0; i < n - 1; i++){
			int c; in >> c;
			f.push_back(c);
			sf += c;
		}

		for (int i = 0; i < n - 1; i++){
			int c; in >> c;
			s.push_back(c);
			ss += c;
		}

		for (int i = 0; i < n; i++){
			int c; in >> c;
			p.push_back(c);
			sp += c;
		}


		long long ans = 1e9 + 7;

		vector<int> s;

		for (int i = 0; i < n; i++){
			int ca = 0;
			for (int i = )
		}



    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
