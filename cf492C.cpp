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
		int n; long long r; long long avg; in >> n >> r >> avg;

		vector<pair<long long ,long long>> e;

		long long sum = 0;
		for (int i = 0; i < n; i++){
			long long  a, b; in >> a >> b;

			e.push_back(make_pair(a, b));
			sum += a;
		}

		std::sort(e.begin(), e.end(), [](pair<long long, long long> &left, pair<long long, long long> &right) {
			return left.second < right.second;
		});

		long long fsum = avg*n;

		long long ans = 0;

		while (sum < fsum){
			int dp = sum - fsum;
			for (int i = 0; i < e.size(); i++){

				if ((sum + (r - e[i].first)) < fsum){
					ans += e[i].second * (r - e[i].first);
					sum += (r - e[i].first);
				}
				else{
					ans += e[i].second * (fsum - sum);
					sum += (r - e[i].first);
					break;
				}
			}
		}

		out << ans;


		/*for (vector<pair<int, int>>::iterator it = e.begin(); it != e.end(); it++){
			out << it->second << " " << it->first << "\n";
		}*/


    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
