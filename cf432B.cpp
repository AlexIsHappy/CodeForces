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

		vector<pair<int, int>> f;

		map<int, int> fc;
		vector<int> af;


		for (int i = 0; i < n; i++){
			int d, v; in >> d >> v;

			af.push_back(d);
			f.push_back(make_pair(d, v));

			if (fc.find(d) == fc.end()){
				fc.insert(make_pair(d,1));
			}
			else{
				fc[d]++;
			}
		}


		int m = (n - 1) * 2;



		vector<pair<int, int>> ans;

		for (int i = 0; i < n; i++){


			if (fc.find(f[i].second) == fc.end()){
				out << m / 2 << " " << m / 2 << endl;
			}
			else{
				int fv = fc[f[i].second];
				out << m / 2 + fv << " " << m / 2 - fv << "\n";
			}
		}
    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
