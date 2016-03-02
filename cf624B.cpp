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
		int n; in >> n;

		vector<int> nums;
		for (int i = 0; i < n; i++){
			int c; in >> c;
			nums.push_back(c);
		}

		sort(nums.begin(), nums.end());

		for (int i = nums.size() - 1; i > 0; i--){
			if (nums[i] == nums[i - 1]){


				for (int j = i - 1; j >= 0; j--){
					if (nums[j] == nums[i])
						nums[j] = nums[j] >= 1 ? nums[j] - 1 : nums[j];
				}
			}
		}

		long long sum = 0;
		for (int i = 0; i < nums.size(); i++){
			//out << nums[i] << " ";
			sum += nums[i];
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
