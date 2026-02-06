# Fork Maintenance Notes \(`README-AM-GIT.md`\)

This document describes how this fork \(`iwhp/gateapi-csharp`\) is kept in sync with the upstream repository \(`gateio/gateapi-csharp`\), and how fork-only files like `README-AM-GIT.md` are handled.

---

## Remotes Setup

Local clone path \(example\):

```
D:\CODE\github\iwhp\gateapi-csharp
```

Remotes:

- `origin` → `https://github.com/iwhp/gateapi-csharp` \(this fork\)
- `upstream` → `https://github.com/gateio/gateapi-csharp` \(original repo\)

Initial setup \(run once\):

```
git remote add upstream https://github.com/gateio/gateapi-csharp.git
git remote -v
```

---

## Keeping the Fork in Sync with Upstream

Work is primarily done on `master`, which is kept close to `upstream/master`.

Regular sync workflow:

```
# Ensure we are on master
git checkout master

# Fetch latest upstream changes
git fetch upstream

# Option A: Rebase onto upstream/master (preferred)
git rebase upstream/master

# Option B: Merge upstream/master (if you prefer merge commits)
# git merge upstream/master

# Push updated master to this fork
git push origin master
```

This keeps `origin/master` aligned with `upstream/master` while maintaining local/remote history consistency for this fork.

---

## Fork-Only Files \(`README-AM-GIT.md`\)

`README-AM-GIT.md` is intended to exist only in:

- the local clone \(`D:\CODE\github\iwhp\gateapi-csharp`\),
- this fork on GitHub \(`https://github.com/iwhp/gateapi-csharp`\),

and **must not** be introduced into the upstream repository \(`https://github.com/gateio/gateapi-csharp`\).

Key points:

1. This repository has **no push access** to `gateio/gateapi-csharp`, so nothing is pushed there directly.
2. Upstream only receives changes via Pull Requests created from branches in this fork.
3. To ensure `README-AM-GIT.md` never appears upstream:
   - Avoid including `README-AM-GIT.md` in branches that are used for PRs to `gateio/gateapi-csharp`.
   - If it is present on such a branch, remove it from the commits before opening a PR \(for example, via interactive rebase or by not committing it on that branch\).

A simple, safe practice:

- Keep `master` as the “upstream-sync” branch, containing only changes that are acceptable for upstream.
- Use separate branches for fork-only experiments or documentation that will never be proposed upstream.

---

## `git_push.sh` Script Behavior

The repository contains a helper script:

```
git_push.sh
```

Behavior summary:

- Initializes the directory as a Git repository \(if not already\).
- Adds **all** files \(`git add .`\).
- Commits with a message provided as an argument \(or default\).
- Sets `origin` to `https://github.com/gateio/gateapi-csharp` by default when no arguments are provided.
- Executes:

```
git pull origin master
git push origin master
```

Important considerations:

1. For this fork, `origin` is explicitly configured as:

   ```
   https://github.com/iwhp/gateapi-csharp
   ```

   so `git_push.sh` will push to this fork, not to the upstream repo.

2. Because the script does `git add .`, any tracked files \(including `README-AM-GIT.md` if it is tracked\) will be staged and committed when the script is used.

3. This is acceptable as long as:

   - `README-AM-GIT.md` is not part of branches intended for Pull Requests to `gateio/gateapi-csharp`, or  
   - before opening a PR, commits containing `README-AM-GIT.md` are cleaned up \(for example, via rebase\), or the file is removed from that branch.

If a stricter separation is desired, the script could be modified to avoid blindly adding all files \(for example, by listing files explicitly or by using `.gitignore`\), but the current behavior is sufficient as long as branch discipline is maintained.

---

## Conflict Handling Strategy \(README-type Files\)

When synchronizing with upstream \(via `rebase` or `merge`\), if there are conflicts in documentation files \(for example, `README.md`\), the following approach is used:

- For the upstream-facing documentation \(`README.md`\), conflicts are resolved case-by-case depending on whether upstream or fork-specific changes should win.
- Fork-only files like `README-AM-GIT.md` are not expected to conflict with upstream, because they are not present there and are not proposed in PRs.

Example of keeping local changes during a conflict on a shared file:

```
# During rebase/merge conflict
git checkout --ours README.md
git add README.md
git rebase --continue   # or: git commit, if merging
```

This keeps the fork’s version of `README.md` in that specific context.

---

## Summary

- `upstream` is configured to `https://github.com/gateio/gateapi-csharp`.
- `origin` is this fork: `https://github.com/iwhp/gateapi-csharp`.
- Sync with upstream via:

  ```
  git checkout master
  git fetch upstream
  git rebase upstream/master
  git push origin master
  ```

- `README-AM-GIT.md` is fork-only and must not be included in any Pull Request branches intended for `gateio/gateapi-csharp`.
- The `git_push.sh` script pushes changes only to this fork’s `origin`; discipline around which branches are used for PRs ensures that fork-only files never reach upstream.