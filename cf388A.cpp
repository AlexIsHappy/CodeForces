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

		vector<int>nums;

		for (int i = 0; i < n; i++){
			int c; in >> c;
			nums.push_back(c);
		}

		sort(nums.rbegin(), nums.rend());
		vector<bool> used(n);


		int res = 0;
		for (int i = 0; i < n; i++){
			if (used[i])
				continue;

			res++;

			for (int j = nums[i] - 1; j >= 0; j--){
				for (int k = n - 1; k > i; k--){
					if (!used[k] && nums[k] >= j){
						used[k] = true;
						break;
					}
				}
			}
		}

		out << res;

    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
