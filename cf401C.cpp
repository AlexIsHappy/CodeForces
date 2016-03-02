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

		int mn = 0;
		if (m % 2 == 0) mn = (m - 2) / 2;
		else mn = (m - 1) / 2;

		int mx = m + 1;

		string ans = "";
		if (n >= mn && n <= mx){

			string s1 = "";

			while (m > 0){
				if (m >= 2){
					s1 += "11";
					m -= 2;

					if (n > 0 && m > 0)
					{
						s1 += '0';
						n--;
					}
				}
				else {
					s1 += "1";
					m -= 1;
				}
			}

			//out << s1 << "\n";
			ans += "1";
			
			if (n > 0){
				for (int i = 1; i < s1.length(); i++){
					if (s1[i] == '1' && s1[i - 1] == '1'){
						ans += '0';
						ans += s1[i];
						n--;
					}
					else{
						ans += s1[i];
					}

					if (n == 0){
						for (int j = i + 1; j < s1.length(); j++){
							ans += s1[j];
						}
						break;
					}
				}
			}
			else{
				ans = s1;
			}

			if (n > 0){
				ans = '0' + ans;
				n--;
			}

			if (n > 0){
				ans = ans + '0';
				n--;
			}

			out << ans;

		}
		else{
			out << -1;
		} 
    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
