# Make Your Day
턴 시작시 5장의 카드(1장은 수면 카드로 고정)를 뽑음
1장(수면 카드 제외)을 사용하면 다시 1장을 뽑음

## Art style
- 책상을 내려다 보는 시점<br/>
- GUI 최소화 <br/>

## system
### Turn System
하루는 24턴<br/> 
고정 행동(식사시간, 수업시간, mt 등)이 있는턴이 있음

### 피로도 token system
- 카드를 사용해 턴을 소비할때마다 피로도가 증가<br/>
- 수면 카드를 활용해 피로도를 감소 시킬 수 있음<br/>
- 일정 수치 이상이면 피로도를 모두 회복할때까지 자야함<br/>
- 일정 수치 이상이면 행동 시간이 증가함 <br/>

## 카드
### 과목 카드
과목은 총 4가지로 이루어져 있음(각각 빨간색, 노란색, 파란색, 초록색)<br/>
1주일(7일, 168턴)당 5장씩 모아야함
| 이름 | 색 |소요시간 | 피로도 |
| ------ | ----- | ------ | ---- |
| Basic 3D | red | 3/5/7 | 5/9/13 |
| Basic 2D | green | 2/4/6 | 3/5/7 |
| math(1) | blue | 1/1 | 1/2 |
| marketing | yellow | 1/2/3 | 2/3/5

### 취미 카드
사용시 점수가 올라감
게임, 음악 감상, 독서
| 소요시간 | 피로도 |
| ----- | ---- |
| 1 | 1 |

### 수면 카드
사용시 피로도가 감소함<br/>
사용시 다시 손으로 돌아옴 <br/>
2번 이상 수면 카드를 사용하고 다른 카드를 사용하면 다음턴이 올때까지 소멸 <br/>
| 소요시간 | 피로도 감소량 | 총 피로도 감소량 |
| ----- | ----- | ----- |
| 1 | 1 | 1 |
| 2 | 2 | 3 |
| 3 | 3 | 6 |
| 4 | 4 | 10 |
| 5 | 5 | 15 |
| 6 | 6 | 21 |
| 7 | 6 | 27 |
| 8 | 6 | 33 |
| 9 | 6 | 39 |
| 10 | 6 | 45 |
| 11 | 3 | 48 |
| 12~ | 1 | 49+ |
