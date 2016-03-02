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
		int n; int k; in >> n >> k;

		vector<int> d;

		for (int i = 0; i < n; i++){
			int c; in >> c;

			d.push_back(c);
		}

		int mins = 1000000000;
		int ans = 0;


		int curs = 0;
		for (int i = 0; i < k; i++){
			curs += d[i];
		}

		mins = min(mins, curs);

		//out << curs << "\n";
		for (int i = 1; i < n; i++){
			curs -= d[i-1];

			if ((i + k ) > n){
				break;
			}
			else{
				curs += d[i + k - 1];
			}
			if (curs < mins){
				ans = i;
				mins = curs;
			}

			//out << mins << "" << ans << "\n";
		}

		out << ans + 1;
    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
