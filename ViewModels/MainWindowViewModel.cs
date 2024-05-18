﻿using System.Collections.Generic;
using Task44.Models;
using System;

namespace Task44.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        BlogEntities =
            [
            new BlogEntity { Article = "Article 1", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam tempus nulla at nulla luctus pulvinar. Quisque ullamcorper sem sit amet elementum efficitur. Ut eu euismod ipsum. Morbi feugiat dolor quis ligula efficitur, eu maximus augue porttitor. Duis tincidunt a velit in vehicula. Nullam ornare erat eu magna interdum, et pellentesque ante dignissim. Ut in velit porta, fermentum tellus eu, dapibus sem. Sed efficitur felis in nisi aliquam semper. Nam nec feugiat risus. Fusce aliquet felis sit amet ipsum suscipit iaculis. Nam eget mattis risus. Aenean id scelerisque lacus. Sed viverra feugiat risus, at dignissim metus ultricies placerat.Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec condimentum consectetur ullamcorper. Integer venenatis, orci vitae tempor volutpat, est libero sagittis ligula, quis dignissim arcu urna vel mauris. Nam consequat porttitor laoreet. Etiam dapibus, felis ut laoreet maximus, massa lacus tempus elit, et pharetra dolor ipsum ac ligula. Cras facilisis nibh quis interdum congue. Nulla vitae massa sodales arcu semper dignissim vel at dui. Sed porta nunc ut dictum finibus. Aliquam interdum maximus enim et lacinia. Curabitur sit amet eros at nunc iaculis aliquet sit amet vel neque. Nam rutrum, mauris at vulputate tincidunt, magna odio pharetra felis, in suscipit turpis sapien et felis. Aenean id faucibus massa, sit amet vestibulum justo. Proin ut ipsum non massa varius fringilla. Cras pulvinar in lectus a ornare. Vestibulum in neque vitae massa imperdiet pellentesque.", TagsList = ["Tag 1", "Tag 2", "Tag 3", "Tag 4"], ImagePath = "LoremHero.png" },
            new BlogEntity { Article = "Article 2", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam tempus nulla at nulla luctus pulvinar. Quisque ullamcorper sem sit amet elementum efficitur. Ut eu euismod ipsum. Morbi feugiat dolor quis ligula efficitur, eu maximus augue porttitor. Duis tincidunt a velit in vehicula. Nullam ornare erat eu magna interdum, et pellentesque ante dignissim. Ut in velit porta, fermentum tellus eu, dapibus sem. Sed efficitur felis in nisi aliquam semper. Nam nec feugiat risus. Fusce aliquet felis sit amet ipsum suscipit iaculis. Nam eget mattis risus. Aenean id scelerisque lacus. Sed viverra feugiat risus, at dignissim metus ultricies placerat.tOrci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec condimentum consectetur ullamcorper. Integer venenatis, orci vitae tempor volutpat, est libero sagittis ligula, quis dignissim arcu urna vel mauris. Nam consequat porttitor laoreet. Etiam dapibus, felis ut laoreet maximus, massa lacus tempus elit, et pharetra dolor ipsum ac ligula. Cras facilisis nibh quis interdum congue. Nulla vitae massa sodales arcu semper dignissim vel at dui. Sed porta nunc ut dictum finibus. Aliquam interdum maximus enim et lacinia. Curabitur sit amet eros at nunc iaculis aliquet sit amet vel neque. Nam rutrum, mauris at vulputate tincidunt, magna odio pharetra felis, in suscipit turpis sapien et felis. Aenean id faucibus massa, sit amet vestibulum justo. Proin ut ipsum non massa varius fringilla. Cras pulvinar in lectus a ornare. Vestibulum in neque vitae massa imperdiet pellentesque.", TagsList = ["Tag 1", "Tag 2", "Tag 3", "Tag 4"], ImagePath = "LoremHero.png" },
            new BlogEntity { Article = "Article 3", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam tempus nulla at nulla luctus pulvinar. Quisque ullamcorper sem sit amet elementum efficitur. Ut eu euismod ipsum. Morbi feugiat dolor quis ligula efficitur, eu maximus augue porttitor. Duis tincidunt a velit in vehicula. Nullam ornare erat eu magna interdum, et pellentesque ante dignissim. Ut in velit porta, fermentum tellus eu, dapibus sem. Sed efficitur felis in nisi aliquam semper. Nam nec feugiat risus. Fusce aliquet felis sit amet ipsum suscipit iaculis. Nam eget mattis risus. Aenean id scelerisque lacus. Sed viverra feugiat risus, at dignissim metus ultricies placerat.Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec condimentum consectetur ullamcorper. Integer venenatis, orci vitae tempor volutpat, est libero sagittis ligula, quis dignissim arcu urna vel mauris. Nam consequat porttitor laoreet. Etiam dapibus, felis ut laoreet maximus, massa lacus tempus elit, et pharetra dolor ipsum ac ligula. Cras facilisis nibh quis interdum congue. Nulla vitae massa sodales arcu semper dignissim vel at dui. Sed porta nunc ut dictum finibus. Aliquam interdum maximus enim et lacinia. Curabitur sit amet eros at nunc iaculis aliquet sit amet vel neque. Nam rutrum, mauris at vulputate tincidunt, magna odio pharetra felis, in suscipit turpis sapien et felis. Aenean id faucibus massa, sit amet vestibulum justo. Proin ut ipsum non massa varius fringilla. Cras pulvinar in lectus a ornare. Vestibulum in neque vitae massa imperdiet pellentesque.", TagsList = ["Tag 1", "Tag 2", "Tag 3", "Tag 4"], ImagePath = "LoremHero.png" }
            ];
        NewsEntities =
            [
            new NewsEntity { Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Duis tincidunt diam ac quamlobortis dignissim.Vivamus tempusaccumsan tincidunt.Pellentesque a semper metus, quis imperdiet urna. Duis egestas elit a commodo fermentum...", PublishDate = DateTime.Now},
            new NewsEntity { Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Duis tincidunt diam ac quamlobortis dignissim.Vivamus tempusaccumsan tincidunt.Pellentesque a semper metus, quis imperdiet urna. Duis egestas elit a commodo fermentum...", PublishDate = DateTime.Now},
            new NewsEntity { Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Duis tincidunt diam ac quamlobortis dignissim.Vivamus tempusaccumsan tincidunt.Pellentesque a semper metus, quis imperdiet urna. Duis egestas elit a commodo fermentum...", PublishDate = DateTime.Now }
            ];
    }
    public List<BlogEntity> BlogEntities { get; set; }
    public List<NewsEntity> NewsEntities { get; set; }
}