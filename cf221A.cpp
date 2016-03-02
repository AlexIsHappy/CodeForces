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
	void solve(std::istream& in, std::ostream& out){
		int n; in >> n;

		vector<int> a;
		for (int i = 1; i <= n; i++){
			a.push_back(i);
		}

		out << a[n-1] << " ";

		for (int i = 0; i < n - 1; i++){
			out << a[i] << " ";
		}

    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
