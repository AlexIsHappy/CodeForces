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

		int n, p; in >> n >> p;

		vector<pair<int, int>> pnt;


		for (int i = 0; i < n; i++){
			int t, s; in >> t >> s;

			pnt.push_back(make_pair(t, -s));
		}

		sort(pnt.rbegin(), pnt.rend());

		int res = count(pnt.begin(), pnt.end(), pnt[p - 1]);

		out << res;
    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
