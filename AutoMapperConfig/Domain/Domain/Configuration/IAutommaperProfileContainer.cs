using AutoMapper;

namespace Domain.Configuration
{
    public interface IAutommaperProfileContainer
    {
        Profile GetProfile();
    }
}