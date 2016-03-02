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
		vector<pair<int,string>> ans;
		vector<string> init;

		for (int i = 0; i < 4; i++){
			string c; in >> c;

			init.push_back(c);
			ans.push_back(make_pair(c.length() - 2, c));
		}

		sort(ans.begin(), ans.end());

		if (ans[1].first / ans[0].first >= 2 && ans[3].first / ans[2].first >= 2){
			out << init[2][0];
			return;
		}
		else if (ans[1].first / ans[0].first >= 2){
			out << ans[0].second[0];
			return;
		} 
		else if (ans[3].first / ans[2].first >= 2){
			out << ans[3].second[0];
			return;
		}
		else{
			out << init[2][0];
		}



    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
