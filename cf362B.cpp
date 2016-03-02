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
		int n, m; in >> n >> m;

		vector<int> s;
		for (int i = 0; i < m; i++){
			int c; in >> c;
			s.push_back(c);
			if (c == 1 || c == n){
				out << "NO"; return;
			}

		}

		sort(s.begin(), s.end());

		if (n >= 3){
			for (int i = 2; i < s.size(); i++){
				if ((s[i - 2] + 1) == s[i - 1] && (s[i - 1] + 1) == s[i]){
					out << "NO"; return;
				}
			}

			out << "YES";
			return;
		}
		else{
			out << "YES";
		}

	}
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
