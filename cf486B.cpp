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


int a[101][101];
class Solution {
public:
    void solve(std::istream& in, std::ostream& out) {
		int m, n; in >> m >> n;

		vector<pair<int, int>> ed;

		for (int i = 0; i < m; i++){
			for (int j = 0; j < n; j++){
				int c; in >> c;
				a[i][j] = c;

				if (c == 1)
					ed.push_back(make_pair(i, j));
			}
		}

		if (ed.size() == 0){
			out << "YES" << endl;
			for (int i = 0; i < m; i++){
				for (int j = 0; j < n; j++){
					out << a[i][j] << " ";
				}
				out << endl;
			}

			return;
		}

		int ans[100][100];
		for (int i = 0; i < m; i++){
			for (int j = 0; j < n; j++){
				ans[i][j] = 0;
			}
		}

		bool isEd = false;
		for (int i = 0; i < ed.size(); i++){
			// Check for row
			int cnt = 0;
			bool isO = true;

			int x = ed[i].first; int y = ed[i].second;

			for (int i = 0; i < n; i++){
				if (a[x][i] != 1)
				{
					isO = false;
					break;
				}
			}

			for (int i = 0; i < m; i++){
				if (a[i][y] != 1){
					isO = false;
					break;
				}
			}

			if (isO){
				ans[x][y] = 1;
				isEd = true;
			}
			else{
				ans[x][y] = 0;
			}

		}

		if (isEd){
			out << "YES" << "\n";
			for (int i = 0; i < m; i++){
				for (int j = 0; j < n; j++){
					out << ans[i][j] << " ";
				}
				out << endl;
			}
		}
		else{
			out << "NO";
		}
    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
