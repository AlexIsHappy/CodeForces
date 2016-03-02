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

struct sort_pred {
	bool operator()(const std::pair<int, int> &left, const std::pair<int, int> &right) {
		return left.second < right.second;
	}
};

class Solution {
public:
	void solve(std::istream& in, std::ostream& out) {
		int n; in >> n;
		vector< pair<int, int> > d;

		for (int i = 0; i < n; i++){
			int c; in >> c;

			d.push_back(make_pair(i, c));
		}

		sort(d.begin(), d.end(), sort_pred());

		int count = 0;


		vector<vector<int>> answ;
		vector<int> ans;
		vector<int> orans;

		for (int i = 0; i < d.size(); i++){
			ans.push_back(d[i].first + 1);
		}

		answ.push_back(ans);

		for (int i = 1; i < d.size(); i++){
			if (d[i].second == d[i - 1].second){
				count++;

				vector<int> nans = ans;
				nans[i] = d[i - 1].first + 1;
				nans[i - 1] = d[i].first + 1;
				answ.push_back(nans);
			}
		}

		if (count >= 2){
			out << "YES" << "\n";

			for (int i = 0; i < 3; i++){
				for (int j = 0; j < answ[i].size(); j++){
					out << answ[i][j] << " ";
				}
				out << "\n";
			}
		}
		else
		{
			out << "NO";
		}



    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
