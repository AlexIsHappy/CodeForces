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

long long d[2000000];
#define MOD 1000000007

class Solution {
public:
    void solve(std::istream& in, std::ostream& out) {
		int t, k; in >> t >> k;
 
		d[0] = 1;

		for (int i = 1; i <= 100000; i++)
		{
			d[i] = d[i - 1] + (i >= k ? d[i - k] : 0);
			d[i] %= MOD;
		}

		for (int i = 1; i <= 100000; i++)
		{
			d[i] += d[i - 1];
		}

		int ans = 0;
		for (int i = 0; i < t; i++){
			int a, b; in >> a >> b;
			ans = ((d[b] - d[a-1]) + MOD)%MOD;
			out << ans << "\n";
		}

    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
