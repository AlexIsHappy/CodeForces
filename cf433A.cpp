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

		if (n == 1){
			out << "NO"; return;
		  return;
		}
		int s = 0;

		vector<int> a;
		for (int i = 0; i < n; i++){
			int c; in >> c;
			s += c;
			a.push_back(c);
		}

		if (s % 200 != 0){
			out << "NO";  return;
		}

		sort(a.begin(), a.end());

		int h = s / 2;

		int ch = 0;

		for (int i = 0; i < n; i++){
			ch += a[i];

			if (ch == h && (s - ch) == h){
				out << "YES";
				return;
			}
		}

		out << "NO";

    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
