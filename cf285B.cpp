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
		int n, s, t; in >> n >> s >> t;

		vector<int>p;
		for (int i = 0; i < n; i++){
			int c; in >> c;
			p.push_back(c);
		}

		int count = 0;
		set<int> ps;
		ps.insert(count);

		while (s != t){
			count++;
			s = p[s - 1];

			if (ps.count(s) == 1){
				out << "-1";
				return;
			}

			ps.insert(s);
		}

		out << count;
    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
