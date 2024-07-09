using YuChingECommerce.Services.RewardAPI.Message;

namespace YuChingECommerce.Services.RewardAPI.Services
{
    public interface IRewardService
    {
        Task UpdateRewards(RewardsMessage rewardsMessage);
    }
}
