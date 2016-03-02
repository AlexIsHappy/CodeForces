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
		int n, d; in >> n >> d;

		vector<int> nums;
		for (int i = 0; i < n; i++){
			int c; in >> c;
			nums.push_back(c);
		}

		int m; in >> m;

		sort(nums.begin(), nums.end());

		int sum = 0;
		if (m <= nums.size()){
			for (int i = 0; i < m; i++){
				sum += nums[i];
			}
		}
		else{
			for (int i = 0; i < nums.size(); i++){
				sum += nums[i];
			}

			sum -= (d * (m - nums.size()));
		}

		out << sum;


    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
