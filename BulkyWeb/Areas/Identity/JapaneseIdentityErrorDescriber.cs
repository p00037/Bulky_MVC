namespace BulkyBookWeb.Areas.Identity
{
    using Microsoft.AspNetCore.Identity;

    public class JapaneseIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError DefaultError()
            => new IdentityError { Code = nameof(DefaultError), Description = "不明なエラーが発生しました。" };

        public override IdentityError ConcurrencyFailure()
            => new IdentityError { Code = nameof(ConcurrencyFailure), Description = "同時更新エラーが発生しました。" };

        public override IdentityError PasswordMismatch()
            => new IdentityError { Code = nameof(PasswordMismatch), Description = "パスワードが一致しません。" };

        public override IdentityError InvalidToken()
            => new IdentityError { Code = nameof(InvalidToken), Description = "トークンが無効です。" };

        public override IdentityError LoginAlreadyAssociated()
            => new IdentityError { Code = nameof(LoginAlreadyAssociated), Description = "このログイン情報は既に他のユーザーに関連付けられています。" };

        public override IdentityError InvalidUserName(string? userName)
            => new IdentityError { Code = nameof(InvalidUserName), Description = $"ユーザー名「{userName}」は無効です。" };

        public override IdentityError InvalidEmail(string? email)
            => new IdentityError { Code = nameof(InvalidEmail), Description = $"メールアドレス「{email}」は無効です。" };

        public override IdentityError DuplicateUserName(string userName)
            => new IdentityError { Code = nameof(DuplicateUserName), Description = $"ユーザー名「{userName}」は既に使用されています。" };

        public override IdentityError DuplicateEmail(string email)
            => new IdentityError { Code = nameof(DuplicateEmail), Description = $"メールアドレス「{email}」は既に登録されています。" };

        public override IdentityError InvalidRoleName(string? role)
            => new IdentityError { Code = nameof(InvalidRoleName), Description = $"ロール名「{role}」は無効です。" };

        public override IdentityError DuplicateRoleName(string role)
            => new IdentityError { Code = nameof(DuplicateRoleName), Description = $"ロール名「{role}」は既に存在します。" };

        public override IdentityError UserAlreadyHasPassword()
            => new IdentityError { Code = nameof(UserAlreadyHasPassword), Description = "ユーザーはすでにパスワードを持っています。" };

        public override IdentityError UserLockoutNotEnabled()
            => new IdentityError { Code = nameof(UserLockoutNotEnabled), Description = "このユーザーのロックアウトは有効になっていません。" };

        public override IdentityError UserAlreadyInRole(string role)
            => new IdentityError { Code = nameof(UserAlreadyInRole), Description = $"ユーザーは既にロール「{role}」に属しています。" };

        public override IdentityError UserNotInRole(string role)
            => new IdentityError { Code = nameof(UserNotInRole), Description = $"ユーザーはロール「{role}」に属していません。" };

        public override IdentityError PasswordTooShort(int length)
            => new IdentityError { Code = nameof(PasswordTooShort), Description = $"パスワードは最低 {length} 文字必要です。" };

        public override IdentityError PasswordRequiresNonAlphanumeric()
            => new IdentityError { Code = nameof(PasswordRequiresNonAlphanumeric), Description = "パスワードには少なくとも1つの記号（例: !@#$%^&*）が必要です。" };

        public override IdentityError PasswordRequiresDigit()
            => new IdentityError { Code = nameof(PasswordRequiresDigit), Description = "パスワードには少なくとも1つの数字（0～9）が必要です。" };

        public override IdentityError PasswordRequiresLower()
            => new IdentityError { Code = nameof(PasswordRequiresLower), Description = "パスワードには少なくとも1つの小文字が必要です。" };

        public override IdentityError PasswordRequiresUpper()
            => new IdentityError { Code = nameof(PasswordRequiresUpper), Description = "パスワードには少なくとも1つの大文字が必要です。" };

        public override IdentityError PasswordRequiresUniqueChars(int uniqueChars)
            => new IdentityError { Code = nameof(PasswordRequiresUniqueChars), Description = $"パスワードには少なくとも {uniqueChars} 種類の異なる文字が必要です。" };

        public override IdentityError RecoveryCodeRedemptionFailed()
            => new IdentityError { Code = nameof(RecoveryCodeRedemptionFailed), Description = "リカバリーコードの使用に失敗しました。" };

        //public override IdentityError ExternalLoginExists()
        //    => new IdentityError { Code = nameof(ExternalLoginExists), Description = "この外部ログインはすでに使用されています。" };
    }

}
