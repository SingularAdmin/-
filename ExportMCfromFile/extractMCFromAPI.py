#!/usr/bin/env python3

triviafile = 'trivia.csv'
apiurl = 'https://opentdb.com/'
sleep_between_requests = 0.1
questionsPerRequest = 50

import requests, os, hashlib, json, sys, csv, urllib, time

unquote = urllib.parse.unquote

def cget(url, cachedir = b'cache'):
    ''' Cached GET request. The URL must be an UTF-8 string and cachedir should be bytes. '''

    global _cache, _cacheindex

    if not os.path.isdir(cachedir):
        os.mkdir(cachedir)

    if '_cache' not in globals():
        indexfile = os.path.join(cachedir, b'index')
        if os.path.isfile(indexfile):
            with open(indexfile) as f:
                _cache = f.read().replace('\r', '').split('\n')
        else:
            _cache = {}

        _cacheindex = open(indexfile, 'a')

    h = b'c-' + bytes(hashlib.new('md5', bytes(url, 'utf-8')).hexdigest(), 'utf-8')
    fname = os.path.join(cachedir, h)

    if url in _cache:
        with open(fname) as f:
            return f.read()

    print('Performing GET for {}'.format(url))
    response = requests.get(url)
    if response.status_code != 200:
        return False

    with open(fname, 'w') as f:
        f.write(response.text)

    _cache.append(url)
    _cacheindex.write(url + '\n')

    return response.text


#{'overall': {'total_num_of_questions': 6098, 'total_num_of_pending_questions': 1710, 'total_num_of_verified_questions': 3031, 'total_num_of_rejected_questions': 1357}, 'categories': {'9': {'total_num_of_questions': 822, 'total_num_of_pending_questions': 307, 'total_num_of_verified_questions': 208, 'total_num_of_rejected_questions': 307}, '10': {'total_num_of_questions': 134, 'total_num_of_pending_questions': 50, 'total_num_of_verified_questions': 69, 'total_num_of_rejected_questions': 15}, '11': {'total_num_of_questions': 296, 'total_num_of_pending_questions': 83, 'total_num_of_verified_questions': 179, 'total_num_of_rejected_questions': 34}, '12': {'total_num_of_questions': 459, 'total_num_of_pending_questions': 130, 'total_num_of_verified_questions': 270, 'total_num_of_rejected_questions': 59}, '13': {'total_num_of_questions': 37, 'total_num_of_pending_questions': 8, 'total_num_of_verified_questions': 22, 'total_num_of_rejected_questions': 7}, 
counts = json.loads(cget('{}api_count_global.php'.format(apiurl)))
totalrows = int(counts['overall']['total_num_of_verified_questions'])

# {'trivia_categories': [{'id': 9, 'name': 'General Knowledge'}, {'id': 10, 'name': 'Entertainment: Books'}, {'id': 11, 'name': 'Entertainment: Film'}, {'id': 12, 'name': 'Entertainment: Music'}, {'id': 13, 'name': 'Entertainment: Musicals & Theatres'}, {'id': 14, 'name': 'Entertainment: Television'}, {'id': 15, 'name': 'Entertainment: Video Games'}, {'id': 16, 'name': 'Entertainment: Board Games'}, {'id': 17, 'name': 'Science & Nature'}, {'id': 18, 'name': 'Science: Computers'}, {'id': 19, 'name': 'Science: Mathematics'}, {'id': 20, 'name': 'Mythology'}, {'id': 21, 'name': 'Sports'}, {'id': 22, 'name': 'Geography'}, {'id': 23, 'name': 'History'}, {'id': 24, 'name': 'Politics'}, {'id': 25, 'name': 'Art'}, {'id': 26, 'name': 'Celebrities'}, {'id': 27, 'name': 'Animals'}, {'id': 28, 'name': 'Vehicles'}, {'id': 29, 'name': 'Entertainment: Comics'}, {'id': 30, 'name': 'Science: Gadgets'}, {'id': 31, 'name': 'Entertainment: Japanese Anime & Manga'}, {'id': 32, 'name': 'Entertainment: Cartoon & Animations'}]}
tmpcats = json.loads(cget('{}api_category.php'.format(apiurl)))
cats = {}
for cat in tmpcats['trivia_categories']:
    cats[cat['id']] = cat['name']

del tmpcats

if '-h' in sys.argv or '--help' in sys.argv:
    print('''Usage:
  getanswers.py
It will create a directory called "cache" and a file called "trivia.csv".
The file trivia.csv has its own headers, so the fields should be clear.
The first answer, 'Answer 1', is the correct answer to the question.
Answers 3 and 4 are empty if the type is 'boolean' (true/false question).
''')
    exit(1)

out = csv.writer(open(triviafile, 'w', newline=''))
out.writerow(['Category', 'Type', 'Difficulty', 'Question', 'Answer 1', 'Answer 2', 'Answer 3', 'Answer 4'])

token = requests.get('https://opentdb.com/api_token.php?command=request').json()['token']

donerows = 0
last = False
while True:
    if totalrows - donerows <= 0:
        questionsPerRequest = 1
        print('Should be done, adjusting questions per request to 1')

    elif totalrows - donerows < questionsPerRequest:
        questionsPerRequest = totalrows - donerows
        print('Should be done soon, adjusting questions per request to {}'.format(questionsPerRequest))

    request = requests.get('{}api.php?amount={}&token={}&encode=url3986'.format(apiurl, questionsPerRequest, token)).json()
    if request['response_code'] == 4:
        last = True

    elif request['response_code'] != 0:
        print('Error: response code {}. Full response:\n{}'.format(request['response_code'], json.dumps(request)))
        exit(2)

    rows = []
    for question in request['results']:
        cat = unquote(question['category'])
        typ = unquote(question['type'])
        dif = unquote(question['difficulty'])
        q = unquote(question['question'])
        answers = [unquote(question['correct_answer'])] + [unquote(_) for _ in question['incorrect_answers']]
        rows.append([cat, typ, dif, q] + answers)

    out.writerows(rows)
    donerows += len(rows)
    print('Did {}/{} ({}%)...'.format(donerows, totalrows, round(donerows / totalrows * 100, 2)))

    if last:
        print('The API indicated that we are done.')
        break

time.sleep(sleep_between_requests)