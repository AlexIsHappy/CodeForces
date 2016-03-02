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

		int a[] = { 12, 6, 4, 3, 2, 1 };
		for (int i = 0; i < n; i++){
			string s; in >> s;

			vector<int> ans;


			for (int j = 0; j < 6; j++){

				for (int k = 0; k < a[j]; k++){
					int sp = k;
					bool isf = true;
					while (sp < 12){
						//out << sp << " ";
						if (s[sp] == 'O'){
							isf = false;
						}
						sp += a[j];
					}

					//out << "\n";

					if (isf){
						ans.push_back(a[j]);
						break;
					}
				}
			}


			out << ans.size() << " ";

			for (int j = 0; j < ans.size(); j++){
				out << 12 / ans[j] << "x" << ans[j] << " ";
			}
			out << "\n";
		}


    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
