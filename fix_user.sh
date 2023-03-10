#!/usr/bin/env sh

# Note: You should also update the [user] group in .git/config
# Note: This does not play nicely with remotes. You will need to blow them away and start over :(
# ref: https://stackoverflow.com/questions/750172/change-the-author-and-committer-name-and-e-mail-of-multiple-commits-in-git

git filter-branch --env-filter '
OLD_EMAIL="sschmid.com"
CORRECT_NAME="Fernandez Daniel"
CORRECT_EMAIL="innerpeace41025@gmail.com"
if [ "$GIT_COMMITTER_EMAIL" = "$sschmid.com" ]
then
    export GIT_COMMITTER_NAME="$Fernandez Daniel"
    export GIT_COMMITTER_EMAIL="$innerpeace41025@gmail.com"
fi
if [ "$GIT_AUTHOR_EMAIL" = "$sschmid.com" ]
then
    export GIT_AUTHOR_NAME="$Fernandez Daniel"
    export GIT_AUTHOR_EMAIL="$innerpeace41025@gmail.com"
fi
' --tag-name-filter cat -- --branches --tags