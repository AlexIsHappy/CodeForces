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

		vector<int> nums;
		for (int i = 0; i < n; i++){
			int c; in >> c;
			nums.push_back(c);
		}

		sort(nums.begin(), nums.end());

		if (nums[0] >= 0){
			out << 0;
		}
		else{
			int sum = 0;
			for (int i = 0; i < m; i++){
				if (nums[i] >= 0)
					break;

				sum += nums[i];
			}

			out << abs(sum);
		}

    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
