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
		int n;
		in >> n;

		vector<int> nums;
		for (int i = 0; i < n; i++){
			int c; in >> c;
			nums.push_back(c);
		}


		int h = 0;
		int ans = 0;

		for (int i = 0; i < n; i++){
			if (nums[i] == h){
				ans +=2;
			}
			else if (nums[i] > h){
				ans += nums[i] - h;
				h = nums[i];
				ans += 2;
			}
			else if (nums[i] < h){
				ans += h - nums[i];
				h = nums[i];
				ans += 2;
			}
		}

		out << ans-1;
    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
