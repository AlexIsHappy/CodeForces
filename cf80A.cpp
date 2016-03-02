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

inline bool isSimple(int n){
	for (int i = 2; i <= (sqrt(n) + 1); i++){
		if (n % i == 0)
			return false;
	}
	return true;
}

class Solution {
public:
    void solve(std::istream& in, std::ostream& out) {
		int n, m; in >> n >> m;

		int ns = 0;

		for (int i = n + 1; i <= m; i++){
			if (isSimple(i)){
				ns = i;
				break;
			}
		}

		if (ns == m)
			out << "YES";
		else
			out << "NO";
    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
