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


		int ans = nums[0] == 0 ? 1 : 0;
		bool isFound = false;

		vector<int> np;
		if (nums[0] != 0) np.push_back(0);

		for (int i = 1; i < n; i++){
			if (nums[i] == i)
				ans++;
			else{
				if (nums[i] == (i - 1)& nums[i - 1] == (i + 1) && !isFound){
					ans += 2;
					isFound = true;
				}
				else{
					np.push_back(nums[i]);
				}
			}
		}

		int cp = 0;
		bool isf = false;
		for (int i = 0; i < np.size(); i++){
			int pi = nums[np[i]];

			if (nums[pi] == np[i]){
				ans += 2;
				isf = true;
				break;
			}
			else{
				if (nums[np[i]] != np[i])
					cp++;
			}
		}

		if (cp >= 2 && !isf)
			ans++;



		out << ans;
    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
