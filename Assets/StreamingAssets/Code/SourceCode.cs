namespace generators {
    
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class temp_agents : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar1 = default(System.Boolean); //IsContext = False IsNew = False
			Story StoredVariable0 = ((Story)root.GetComponent(typeof(Story))); //IsContext = False IsNew = False
			if(StoredVariable0 != null)
			{
				applicable = true;
				OperandVar1 = applicable;
			}
			return (System.Boolean) (OperandVar1);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class country_cities : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar7 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable2 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable2 != null)
			{
				System.Boolean ifResult3; //IsContext = False IsNew = False
				System.Boolean OperandVar6 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar4 = default(System.String); //IsContext = False IsNew = False
				OperandVar4 = "country_node";
				System.Boolean prop5 = StoredVariable2.HasMarker( (OperandVar4)); //IsContext = False IsNew = False
				OperandVar6 = prop5;
				if(ifResult3 =  (OperandVar6))
				{
					applicable = true;
					OperandVar7 = applicable;
				}
			}
			return (System.Boolean) (OperandVar7);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.country>();
			Entity EntVar8 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar8 != null) EntVar8.ComponentAdded();
			System.Single OperandVar10 = default(System.Single); //IsContext = False IsNew = False
			
			
			System.Single prop9 = External.Random( (4f), (10f)); //IsContext = False IsNew = False
			OperandVar10 = prop9;
			for (int i = 0; i <  (OperandVar10); i++)
			{
				UnityEngine.GameObject city_obj = new UnityEngine.GameObject("city_obj"); //IsContext = False IsNew = False
				
				{
					UnityEngine.GameObject city_obj11 = city_obj; //IsContext = True IsNew = False
					Entity AddContext12 = (Entity)city_obj.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Entity AddContext12 ContextSwitchInterpreter
						if(AddContext12 != null)
						{
							UnityEngine.Vector3 OperandVar18 = default(UnityEngine.Vector3); //IsContext = False IsNew = False
							System.Single OperandVar14 = default(System.Single); //IsContext = False IsNew = False
							
							
							System.Single prop13 = External.Random( (10f), (90f)); //IsContext = False IsNew = False
							OperandVar14 = prop13;
							System.Single OperandVar16 = default(System.Single); //IsContext = False IsNew = False
							
							
							System.Single prop15 = External.Random( (10f), (90f)); //IsContext = False IsNew = False
							OperandVar16 = prop15;
							UnityEngine.Vector3 prop17 = External.Vec( (OperandVar14), (OperandVar16)); //IsContext = False IsNew = False
							OperandVar18 = prop17;
							AddContext12.Position = (UnityEngine.Vector3)( (OperandVar18));
						}
					}
					Place AddContext19 = (Place)city_obj.AddComponent(typeof(Place)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Place AddContext19 ContextSwitchInterpreter
						if(AddContext19 != null)
						{
							
							AddContext19.Size = (System.Int32)( (100f));
						}
					}
					Named AddContext20 = (Named)city_obj.AddComponent(typeof(Named)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Named AddContext20 ContextSwitchInterpreter
						if(AddContext20 != null)
						{
							System.String OperandVar21 = default(System.String); //IsContext = False IsNew = False
							OperandVar21 = "main_name";
							
							System.String OperandVar24 = default(System.String); //IsContext = False IsNew = False
							System.String OperandVar22 = default(System.String); //IsContext = False IsNew = False
							OperandVar22 = "country_name";
							System.String prop23 = External.RandomName( (OperandVar22)); //IsContext = False IsNew = False
							if(prop23 != null)
							{
								OperandVar24 = prop23;
							}
							AddContext20.Set(( (OperandVar21)).ToString(),(System.Single)( (0f)),( (OperandVar24)).ToString());
						}
					}
					Interactables AddContext25 = (Interactables)city_obj.AddComponent(typeof(Interactables)); //IsContext = True IsNew = True
					Interactable AddContext26 = (Interactable)city_obj.AddComponent(typeof(Interactable)); //IsContext = True IsNew = True
					Blackboards.city AddContext27 = (Blackboards.city)city_obj.AddComponent(typeof(Blackboards.city)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Blackboards.city AddContext27 ContextSwitchInterpreter
						if(AddContext27 != null)
						{
							System.Single OperandVar29 = default(System.Single); //IsContext = False IsNew = False
							
							
							System.Single prop28 = External.Random( (3f), (6f)); //IsContext = False IsNew = False
							OperandVar29 = prop28;
							AddContext27.Size = (System.Int32)( (OperandVar29));
							UnityEngine.GameObject OperandVar30 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							OperandVar30 = root;
							AddContext27.Of = (UnityEngine.GameObject)( (OperandVar30));
						}
					}
				}
				UnityEngine.Object.FindObjectOfType<Generators>().Generate(city_obj, 0.1f);
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class temp_cultist : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar32 = default(System.Boolean); //IsContext = False IsNew = False
			Story StoredVariable31 = ((Story)root.GetComponent(typeof(Story))); //IsContext = False IsNew = False
			if(StoredVariable31 != null)
			{
				applicable = true;
				OperandVar32 = applicable;
			}
			return (System.Boolean) (OperandVar32);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class temp_enc : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar34 = default(System.Boolean); //IsContext = False IsNew = False
			Story StoredVariable33 = ((Story)root.GetComponent(typeof(Story))); //IsContext = False IsNew = False
			if(StoredVariable33 != null)
			{
				applicable = true;
				OperandVar34 = applicable;
			}
			return (System.Boolean) (OperandVar34);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class common_noble : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar42 = default(System.Boolean); //IsContext = False IsNew = False
			Interactables StoredVariable35 = ((Interactables)root.GetComponent(typeof(Interactables))); //IsContext = False IsNew = False
			if(StoredVariable35 != null)
			{
				Blackboards.city StoredVariable36 = ((Blackboards.city)StoredVariable35.GetComponent(typeof(Blackboards.city))); //IsContext = False IsNew = False
				if(StoredVariable36 != null)
				{
					System.Boolean ifResult37; //IsContext = False IsNew = False
					
					System.Int32 OperandVar39 = default(System.Int32); //IsContext = False IsNew = False
					if(StoredVariable35 != null)
					{
						System.Int32 prop38 = StoredVariable35.Count; //IsContext = False IsNew = False
						OperandVar39 = prop38;
					}
					
					System.Int32 OperandVar41 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop40 = StoredVariable36.Size; //IsContext = False IsNew = False
					OperandVar41 = prop40;
					if(ifResult37 = ( ( (OperandVar39))) < ( ( (OperandVar41))))
					{
						applicable = true;
						OperandVar42 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar42);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject noble_obj = new UnityEngine.GameObject("noble_obj"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject noble_obj43 = noble_obj; //IsContext = True IsNew = False
				Entity AddContext44 = (Entity)noble_obj.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Markers AddContext45 = (Markers)noble_obj.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				Blackboards.personality AddContext46 = (Blackboards.personality)noble_obj.AddComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = True
				Interactable AddContext47 = (Interactable)noble_obj.AddComponent(typeof(Interactable)); //IsContext = True IsNew = True
				Blackboards.noble AddContext48 = (Blackboards.noble)noble_obj.AddComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.noble AddContext48 ContextSwitchInterpreter
					if(AddContext48 != null)
					{
						UnityEngine.GameObject OperandVar51 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						Blackboards.city StoredVariable49 = ((Blackboards.city)root.GetComponent(typeof(Blackboards.city))); //IsContext = False IsNew = False
						if(StoredVariable49 != null)
						{
							UnityEngine.GameObject prop50 = StoredVariable49.Of; //IsContext = False IsNew = False
							if(prop50 != null)
							{
								OperandVar51 = prop50;
							}
						}
						AddContext48.Of = (UnityEngine.GameObject)( (OperandVar51));
					}
				}
				Named AddContext52 = (Named)noble_obj.AddComponent(typeof(Named)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Named AddContext52 ContextSwitchInterpreter
					if(AddContext52 != null)
					{
						System.String OperandVar53 = default(System.String); //IsContext = False IsNew = False
						OperandVar53 = "main_name";
						
						System.String OperandVar56 = default(System.String); //IsContext = False IsNew = False
						System.String OperandVar54 = default(System.String); //IsContext = False IsNew = False
						OperandVar54 = "human_name";
						System.String prop55 = External.RandomName( (OperandVar54)); //IsContext = False IsNew = False
						if(prop55 != null)
						{
							OperandVar56 = prop55;
						}
						AddContext52.Set(( (OperandVar53)).ToString(),(System.Single)( (0f)),( (OperandVar56)).ToString());
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(noble_obj, 0.1f);
			
			{
				Interactables subContext57 = (Interactables)root.GetComponent(typeof(Interactables)); //IsContext = True IsNew = False
				//ContextStatement Interactables subContext57 ContextSwitchInterpreter
				if(subContext57 != null)
				{
					UnityEngine.GameObject OperandVar58 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar58 = noble_obj;
					subContext57.Attach((UnityEngine.GameObject)( (OperandVar58)));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_emperor : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar73 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable59 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable59 != null)
			{
				Named StoredVariable60 = ((Named)StoredVariable59.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable60 != null)
				{
					System.Boolean ifResult61; //IsContext = False IsNew = False
					
					Blackboards.country OperandVar64 = default(Blackboards.country); //IsContext = False IsNew = False
					if(StoredVariable59 != null)
					{
						UnityEngine.GameObject prop62 = StoredVariable59.Of; //IsContext = False IsNew = False
						if(prop62 != null)
						{
							Blackboards.country StoredVariable63 = ((Blackboards.country)prop62.GetComponent(typeof(Blackboards.country))); //IsContext = False IsNew = False
							if(StoredVariable63 != null)
							{
								OperandVar64 = StoredVariable63;
							}
						}
					}
					
					System.Boolean OperandVar72 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable59 != null)
					{
						UnityEngine.GameObject prop65 = StoredVariable59.Of; //IsContext = False IsNew = False
						if(prop65 != null)
						{
							Blackboards.country StoredVariable66 = ((Blackboards.country)prop65.GetComponent(typeof(Blackboards.country))); //IsContext = False IsNew = False
							if(StoredVariable66 != null)
							{
								System.Boolean ifResult67; //IsContext = False IsNew = False
								System.Boolean OperandVar71 = default(System.Boolean); //IsContext = False IsNew = False
								UnityEngine.GameObject OperandVar69 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								UnityEngine.GameObject prop68 = StoredVariable66.Emperor; //IsContext = False IsNew = False
								if(prop68 != null)
								{
									OperandVar69 = prop68;
								}
								System.Boolean prop70 = External.Has( (OperandVar69)); //IsContext = False IsNew = False
								OperandVar71 = prop70;
								if(ifResult67 = !(OperandVar71))
								{
									OperandVar72 = ifResult67;
								}
							}
						}
					}
					if(ifResult61 = ( ( (OperandVar64))) && ( ( (OperandVar72))))
					{
						applicable = true;
						OperandVar73 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar73);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (10f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Named subContext74 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext74 ContextSwitchInterpreter
				if(subContext74 != null)
				{
					System.String OperandVar75 = default(System.String); //IsContext = False IsNew = False
					OperandVar75 = "postfix";
					
					
					subContext74.Set(( (OperandVar75)).ToString(),(System.Single)( (1f)),( (", the Emperor")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext76 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext76 ContextSwitchInterpreter
				if(subContext76 != null)
				{
					System.Single OperandVar78 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop77 = External.Random( (0.5f), (1f)); //IsContext = False IsNew = False
					OperandVar78 = prop77;
					subContext76.Loyalty = (System.Single)( (OperandVar78));
					System.Single OperandVar80 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop79 = External.Random( (0.4f), (1f)); //IsContext = False IsNew = False
					OperandVar80 = prop79;
					subContext76.Sanity = (System.Single)( (OperandVar80));
					System.Single OperandVar82 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop81 = External.Random( (0.8f), (1f)); //IsContext = False IsNew = False
					OperandVar82 = prop81;
					subContext76.Influence = (System.Single)( (OperandVar82));
					System.Single OperandVar84 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop83 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar84 = prop83;
					subContext76.Knowledge = (System.Single)( (OperandVar84));
					System.Single OperandVar86 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop85 = External.Random( (0.1f), (0.3f)); //IsContext = False IsNew = False
					OperandVar86 = prop85;
					subContext76.Occult = (System.Single)( (OperandVar86));
				}
			}
			
			{
				Blackboards.noble subContext87 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext87 ContextSwitchInterpreter
				if(subContext87 != null)
				{
					
					{
						UnityEngine.GameObject subContext88 = subContext87.Of; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext88 ContextPropertySwitchInterpreter
						if(subContext88 != null)
						{
							
							{
								Blackboards.country subContext89 = (Blackboards.country)subContext88.GetComponent(typeof(Blackboards.country)); //IsContext = True IsNew = False
								//ContextStatement Blackboards.country subContext89 ContextSwitchInterpreter
								if(subContext89 != null)
								{
									UnityEngine.GameObject OperandVar90 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
									OperandVar90 = root;
									subContext89.Emperor = (UnityEngine.GameObject)( (OperandVar90));
								}
							}
						}
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_inquisitor : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar93 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable91 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable91 != null)
			{
				Named StoredVariable92 = ((Named)StoredVariable91.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable92 != null)
				{
					applicable = true;
					OperandVar93 = applicable;
				}
			}
			return (System.Boolean) (OperandVar93);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Named subContext94 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext94 ContextSwitchInterpreter
				if(subContext94 != null)
				{
					System.String OperandVar95 = default(System.String); //IsContext = False IsNew = False
					OperandVar95 = "postfix";
					
					
					subContext94.Set(( (OperandVar95)).ToString(),(System.Single)( (1f)),( (", an inquisitor")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext96 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext96 ContextSwitchInterpreter
				if(subContext96 != null)
				{
					System.Single OperandVar98 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop97 = External.Random( (0.5f), (1f)); //IsContext = False IsNew = False
					OperandVar98 = prop97;
					subContext96.Loyalty = (System.Single)( (OperandVar98));
					System.Single OperandVar100 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop99 = External.Random( (0.4f), (1f)); //IsContext = False IsNew = False
					OperandVar100 = prop99;
					subContext96.Sanity = (System.Single)( (OperandVar100));
					System.Single OperandVar102 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop101 = External.Random( (0.8f), (1f)); //IsContext = False IsNew = False
					OperandVar102 = prop101;
					subContext96.Influence = (System.Single)( (OperandVar102));
					System.Single OperandVar104 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop103 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar104 = prop103;
					subContext96.Knowledge = (System.Single)( (OperandVar104));
					System.Single OperandVar106 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop105 = External.Random( (0.1f), (0.3f)); //IsContext = False IsNew = False
					OperandVar106 = prop105;
					subContext96.Occult = (System.Single)( (OperandVar106));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_trader : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar109 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable107 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable107 != null)
			{
				Named StoredVariable108 = ((Named)StoredVariable107.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable108 != null)
				{
					applicable = true;
					OperandVar109 = applicable;
				}
			}
			return (System.Boolean) (OperandVar109);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Named subContext110 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext110 ContextSwitchInterpreter
				if(subContext110 != null)
				{
					System.String OperandVar111 = default(System.String); //IsContext = False IsNew = False
					OperandVar111 = "postfix";
					
					
					subContext110.Set(( (OperandVar111)).ToString(),(System.Single)( (1f)),( (", a trader")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext112 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext112 ContextSwitchInterpreter
				if(subContext112 != null)
				{
					System.Single OperandVar114 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop113 = External.Random( (0f), (0.3f)); //IsContext = False IsNew = False
					OperandVar114 = prop113;
					subContext112.Loyalty = (System.Single)( (OperandVar114));
					System.Single OperandVar116 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop115 = External.Random( (0.6f), (1f)); //IsContext = False IsNew = False
					OperandVar116 = prop115;
					subContext112.Sanity = (System.Single)( (OperandVar116));
					System.Single OperandVar118 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop117 = External.Random( (0.1f), (0.3f)); //IsContext = False IsNew = False
					OperandVar118 = prop117;
					subContext112.Influence = (System.Single)( (OperandVar118));
					System.Single OperandVar120 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop119 = External.Random( (0.4f), (0.5f)); //IsContext = False IsNew = False
					OperandVar120 = prop119;
					subContext112.Knowledge = (System.Single)( (OperandVar120));
					System.Single OperandVar122 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop121 = External.Random( (0.1f), (0.3f)); //IsContext = False IsNew = False
					OperandVar122 = prop121;
					subContext112.Occult = (System.Single)( (OperandVar122));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_aristocrat : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar125 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable123 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable123 != null)
			{
				Named StoredVariable124 = ((Named)StoredVariable123.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable124 != null)
				{
					applicable = true;
					OperandVar125 = applicable;
				}
			}
			return (System.Boolean) (OperandVar125);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Named subContext126 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext126 ContextSwitchInterpreter
				if(subContext126 != null)
				{
					System.String OperandVar127 = default(System.String); //IsContext = False IsNew = False
					OperandVar127 = "postfix";
					
					
					subContext126.Set(( (OperandVar127)).ToString(),(System.Single)( (1f)),( (", an aristocrat")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext128 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext128 ContextSwitchInterpreter
				if(subContext128 != null)
				{
					System.Single OperandVar130 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop129 = External.Random( (0.5f), (0.6f)); //IsContext = False IsNew = False
					OperandVar130 = prop129;
					subContext128.Loyalty = (System.Single)( (OperandVar130));
					System.Single OperandVar132 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop131 = External.Random( (0.1f), (1f)); //IsContext = False IsNew = False
					OperandVar132 = prop131;
					subContext128.Sanity = (System.Single)( (OperandVar132));
					System.Single OperandVar134 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop133 = External.Random( (0.3f), (0.6f)); //IsContext = False IsNew = False
					OperandVar134 = prop133;
					subContext128.Influence = (System.Single)( (OperandVar134));
					System.Single OperandVar136 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop135 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar136 = prop135;
					subContext128.Knowledge = (System.Single)( (OperandVar136));
					System.Single OperandVar138 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop137 = External.Random( (0.1f), (1f)); //IsContext = False IsNew = False
					OperandVar138 = prop137;
					subContext128.Occult = (System.Single)( (OperandVar138));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_governor : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar141 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable139 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable139 != null)
			{
				Named StoredVariable140 = ((Named)StoredVariable139.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable140 != null)
				{
					applicable = true;
					OperandVar141 = applicable;
				}
			}
			return (System.Boolean) (OperandVar141);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Named subContext142 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext142 ContextSwitchInterpreter
				if(subContext142 != null)
				{
					System.String OperandVar143 = default(System.String); //IsContext = False IsNew = False
					OperandVar143 = "postfix";
					
					
					subContext142.Set(( (OperandVar143)).ToString(),(System.Single)( (1f)),( (", a governor")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext144 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext144 ContextSwitchInterpreter
				if(subContext144 != null)
				{
					System.Single OperandVar146 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop145 = External.Random( (0.2f), (0.6f)); //IsContext = False IsNew = False
					OperandVar146 = prop145;
					subContext144.Loyalty = (System.Single)( (OperandVar146));
					System.Single OperandVar148 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop147 = External.Random( (0.6f), (1f)); //IsContext = False IsNew = False
					OperandVar148 = prop147;
					subContext144.Sanity = (System.Single)( (OperandVar148));
					System.Single OperandVar150 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop149 = External.Random( (0.6f), (0.8f)); //IsContext = False IsNew = False
					OperandVar150 = prop149;
					subContext144.Influence = (System.Single)( (OperandVar150));
					System.Single OperandVar152 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop151 = External.Random( (0f), (0.5f)); //IsContext = False IsNew = False
					OperandVar152 = prop151;
					subContext144.Knowledge = (System.Single)( (OperandVar152));
					System.Single OperandVar154 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop153 = External.Random( (0f), (0.1f)); //IsContext = False IsNew = False
					OperandVar154 = prop153;
					subContext144.Occult = (System.Single)( (OperandVar154));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_general : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar157 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable155 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable155 != null)
			{
				Named StoredVariable156 = ((Named)StoredVariable155.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable156 != null)
				{
					applicable = true;
					OperandVar157 = applicable;
				}
			}
			return (System.Boolean) (OperandVar157);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Named subContext158 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext158 ContextSwitchInterpreter
				if(subContext158 != null)
				{
					System.String OperandVar159 = default(System.String); //IsContext = False IsNew = False
					OperandVar159 = "postfix";
					
					
					subContext158.Set(( (OperandVar159)).ToString(),(System.Single)( (1f)),( (", a general")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext160 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext160 ContextSwitchInterpreter
				if(subContext160 != null)
				{
					System.Single OperandVar162 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop161 = External.Random( (0.7f), (1f)); //IsContext = False IsNew = False
					OperandVar162 = prop161;
					subContext160.Loyalty = (System.Single)( (OperandVar162));
					System.Single OperandVar164 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop163 = External.Random( (0.7f), (1f)); //IsContext = False IsNew = False
					OperandVar164 = prop163;
					subContext160.Sanity = (System.Single)( (OperandVar164));
					System.Single OperandVar166 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop165 = External.Random( (0.3f), (0.4f)); //IsContext = False IsNew = False
					OperandVar166 = prop165;
					subContext160.Influence = (System.Single)( (OperandVar166));
					System.Single OperandVar168 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop167 = External.Random( (0f), (0.2f)); //IsContext = False IsNew = False
					OperandVar168 = prop167;
					subContext160.Knowledge = (System.Single)( (OperandVar168));
					System.Single OperandVar170 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop169 = External.Random( (0f), (0.1f)); //IsContext = False IsNew = False
					OperandVar170 = prop169;
					subContext160.Occult = (System.Single)( (OperandVar170));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_alchemist : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar173 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable171 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable171 != null)
			{
				Named StoredVariable172 = ((Named)StoredVariable171.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable172 != null)
				{
					applicable = true;
					OperandVar173 = applicable;
				}
			}
			return (System.Boolean) (OperandVar173);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Named subContext174 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext174 ContextSwitchInterpreter
				if(subContext174 != null)
				{
					System.String OperandVar175 = default(System.String); //IsContext = False IsNew = False
					OperandVar175 = "postfix";
					
					
					subContext174.Set(( (OperandVar175)).ToString(),(System.Single)( (1f)),( (", an alchemist")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext176 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext176 ContextSwitchInterpreter
				if(subContext176 != null)
				{
					System.Single OperandVar178 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop177 = External.Random( (0f), (0.2f)); //IsContext = False IsNew = False
					OperandVar178 = prop177;
					subContext176.Loyalty = (System.Single)( (OperandVar178));
					System.Single OperandVar180 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop179 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar180 = prop179;
					subContext176.Sanity = (System.Single)( (OperandVar180));
					System.Single OperandVar182 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop181 = External.Random( (0f), (0.1f)); //IsContext = False IsNew = False
					OperandVar182 = prop181;
					subContext176.Influence = (System.Single)( (OperandVar182));
					System.Single OperandVar184 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop183 = External.Random( (0.3f), (1f)); //IsContext = False IsNew = False
					OperandVar184 = prop183;
					subContext176.Knowledge = (System.Single)( (OperandVar184));
					System.Single OperandVar186 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop185 = External.Random( (0.3f), (0.6f)); //IsContext = False IsNew = False
					OperandVar186 = prop185;
					subContext176.Occult = (System.Single)( (OperandVar186));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_mage : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar189 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable187 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable187 != null)
			{
				Named StoredVariable188 = ((Named)StoredVariable187.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable188 != null)
				{
					applicable = true;
					OperandVar189 = applicable;
				}
			}
			return (System.Boolean) (OperandVar189);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Named subContext190 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext190 ContextSwitchInterpreter
				if(subContext190 != null)
				{
					System.String OperandVar191 = default(System.String); //IsContext = False IsNew = False
					OperandVar191 = "postfix";
					
					
					subContext190.Set(( (OperandVar191)).ToString(),(System.Single)( (1f)),( (", a mage")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext192 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext192 ContextSwitchInterpreter
				if(subContext192 != null)
				{
					System.Single OperandVar194 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop193 = External.Random( (0f), (0.2f)); //IsContext = False IsNew = False
					OperandVar194 = prop193;
					subContext192.Loyalty = (System.Single)( (OperandVar194));
					System.Single OperandVar196 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop195 = External.Random( (0f), (0.3f)); //IsContext = False IsNew = False
					OperandVar196 = prop195;
					subContext192.Sanity = (System.Single)( (OperandVar196));
					System.Single OperandVar198 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop197 = External.Random( (0f), (0.5f)); //IsContext = False IsNew = False
					OperandVar198 = prop197;
					subContext192.Influence = (System.Single)( (OperandVar198));
					System.Single OperandVar200 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop199 = External.Random( (0.5f), (1f)); //IsContext = False IsNew = False
					OperandVar200 = prop199;
					subContext192.Knowledge = (System.Single)( (OperandVar200));
					System.Single OperandVar202 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop201 = External.Random( (0.3f), (0.6f)); //IsContext = False IsNew = False
					OperandVar202 = prop201;
					subContext192.Occult = (System.Single)( (OperandVar202));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_priest : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar205 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable203 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable203 != null)
			{
				Named StoredVariable204 = ((Named)StoredVariable203.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable204 != null)
				{
					applicable = true;
					OperandVar205 = applicable;
				}
			}
			return (System.Boolean) (OperandVar205);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Named subContext206 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext206 ContextSwitchInterpreter
				if(subContext206 != null)
				{
					System.String OperandVar207 = default(System.String); //IsContext = False IsNew = False
					OperandVar207 = "postfix";
					
					
					subContext206.Set(( (OperandVar207)).ToString(),(System.Single)( (1f)),( (", a priest")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext208 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext208 ContextSwitchInterpreter
				if(subContext208 != null)
				{
					System.Single OperandVar210 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop209 = External.Random( (0.9f), (1f)); //IsContext = False IsNew = False
					OperandVar210 = prop209;
					subContext208.Loyalty = (System.Single)( (OperandVar210));
					System.Single OperandVar212 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop211 = External.Random( (0.6f), (1f)); //IsContext = False IsNew = False
					OperandVar212 = prop211;
					subContext208.Sanity = (System.Single)( (OperandVar212));
					System.Single OperandVar214 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop213 = External.Random( (0.6f), (0.8f)); //IsContext = False IsNew = False
					OperandVar214 = prop213;
					subContext208.Influence = (System.Single)( (OperandVar214));
					System.Single OperandVar216 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop215 = External.Random( (0.5f), (1f)); //IsContext = False IsNew = False
					OperandVar216 = prop215;
					subContext208.Knowledge = (System.Single)( (OperandVar216));
					System.Single OperandVar218 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop217 = External.Random( (0f), (0f)); //IsContext = False IsNew = False
					OperandVar218 = prop217;
					subContext208.Occult = (System.Single)( (OperandVar218));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class aged_person : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar225 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable219 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable219 != null)
			{
				System.Boolean ifResult220; //IsContext = False IsNew = False
				System.Boolean OperandVar224 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.aged OperandVar222 = default(Blackboards.aged); //IsContext = False IsNew = False
				Blackboards.aged StoredVariable221 = ((Blackboards.aged)StoredVariable219.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
				if(StoredVariable221 != null)
				{
					OperandVar222 = StoredVariable221;
				}
				System.Boolean prop223 = External.Has( (OperandVar222)); //IsContext = False IsNew = False
				OperandVar224 = prop223;
				if(ifResult220 = !(OperandVar224))
				{
					applicable = true;
					OperandVar225 = applicable;
				}
			}
			return (System.Boolean) (OperandVar225);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			Blackboards.aged ContextVar226 = root.AddComponent<Blackboards.aged>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement Blackboards.aged ContextVar226 ContextSwitchInterpreter
				if(ContextVar226 != null)
				{
					System.Single OperandVar228 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop227 = External.Random( (20f), (50f)); //IsContext = False IsNew = False
					OperandVar228 = prop227;
					ContextVar226.Age = (System.Int32)( (OperandVar228));
				}
			}
			Entity EntVar229 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar229 != null) EntVar229.ComponentAdded();
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class beaten_as_a_kid : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar236 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable230 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable230 != null)
			{
				Blackboards.personality StoredVariable231 = ((Blackboards.personality)StoredVariable230.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable231 != null)
				{
					Blackboards.aged StoredVariable232 = ((Blackboards.aged)StoredVariable231.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable232 != null)
					{
						System.Boolean ifResult233; //IsContext = False IsNew = False
						
						System.Int32 OperandVar235 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop234 = StoredVariable232.CurAge; //IsContext = False IsNew = False
						OperandVar235 = prop234;
						
						
						if(ifResult233 = ( ( (OperandVar235))) < ( ( (6f))))
						{
							applicable = true;
							OperandVar236 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar236);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.aged subContext237 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext237 ContextSwitchInterpreter
				if(subContext237 != null)
				{
					
					System.Int32 OperandVar239 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop238 = subContext237.CurAge; //IsContext = False IsNew = False
					OperandVar239 = prop238;
					
					
					subContext237.CurAge = (System.Int32)(( ( (OperandVar239))) + ( ( (3f))));
				}
			}
			
			{
				Blackboards.personality subContext240 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext240 ContextSwitchInterpreter
				if(subContext240 != null)
				{
					
					System.Single OperandVar242 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop241 = subContext240.Cruel; //IsContext = False IsNew = False
					OperandVar242 = prop241;
					
					
					subContext240.Cruel = (System.Single)(( ( (OperandVar242))) + ( ( (0.1f))));
					
					System.Single OperandVar244 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop243 = subContext240.Reckless; //IsContext = False IsNew = False
					OperandVar244 = prop243;
					
					
					subContext240.Reckless = (System.Single)(( ( (OperandVar244))) + ( ( (0.1f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class cherished_as_a_kid : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar251 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable245 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable245 != null)
			{
				Blackboards.personality StoredVariable246 = ((Blackboards.personality)StoredVariable245.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable246 != null)
				{
					Blackboards.aged StoredVariable247 = ((Blackboards.aged)StoredVariable246.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable247 != null)
					{
						System.Boolean ifResult248; //IsContext = False IsNew = False
						
						System.Int32 OperandVar250 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop249 = StoredVariable247.CurAge; //IsContext = False IsNew = False
						OperandVar250 = prop249;
						
						
						if(ifResult248 = ( ( (OperandVar250))) < ( ( (6f))))
						{
							applicable = true;
							OperandVar251 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar251);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.aged subContext252 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext252 ContextSwitchInterpreter
				if(subContext252 != null)
				{
					
					System.Int32 OperandVar254 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop253 = subContext252.CurAge; //IsContext = False IsNew = False
					OperandVar254 = prop253;
					
					
					subContext252.CurAge = (System.Int32)(( ( (OperandVar254))) + ( ( (3f))));
				}
			}
			
			{
				Blackboards.personality subContext255 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext255 ContextSwitchInterpreter
				if(subContext255 != null)
				{
					
					System.Single OperandVar257 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop256 = subContext255.Brave; //IsContext = False IsNew = False
					OperandVar257 = prop256;
					
					
					subContext255.Brave = (System.Single)(( ( (OperandVar257))) - ( ( (0.1f))));
					
					System.Single OperandVar259 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop258 = subContext255.Optimistic; //IsContext = False IsNew = False
					OperandVar259 = prop258;
					
					
					subContext255.Optimistic = (System.Single)(( ( (OperandVar259))) + ( ( (0.2f))));
					
					System.Single OperandVar261 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop260 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar261 = prop260;
					
					
					if(( ( (OperandVar261))) > ( ( (0.9f))))
					{
						
						System.Single OperandVar263 = default(System.Single); //IsContext = False IsNew = False
						System.Single prop262 = subContext255.Cruel; //IsContext = False IsNew = False
						OperandVar263 = prop262;
						
						
						subContext255.Cruel = (System.Single)(( ( (OperandVar263))) + ( ( (0.1f))));
					}
					
					System.Single OperandVar265 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop264 = subContext255.Ambitious; //IsContext = False IsNew = False
					OperandVar265 = prop264;
					
					
					subContext255.Ambitious = (System.Single)(( ( (OperandVar265))) - ( ( (0.03f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class inspired_as_a_kid : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar272 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable266 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable266 != null)
			{
				Blackboards.personality StoredVariable267 = ((Blackboards.personality)StoredVariable266.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable267 != null)
				{
					Blackboards.aged StoredVariable268 = ((Blackboards.aged)StoredVariable267.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable268 != null)
					{
						System.Boolean ifResult269; //IsContext = False IsNew = False
						
						System.Int32 OperandVar271 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop270 = StoredVariable268.CurAge; //IsContext = False IsNew = False
						OperandVar271 = prop270;
						
						
						if(ifResult269 = ( ( (OperandVar271))) < ( ( (6f))))
						{
							applicable = true;
							OperandVar272 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar272);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.aged subContext273 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext273 ContextSwitchInterpreter
				if(subContext273 != null)
				{
					
					System.Int32 OperandVar275 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop274 = subContext273.CurAge; //IsContext = False IsNew = False
					OperandVar275 = prop274;
					
					
					subContext273.CurAge = (System.Int32)(( ( (OperandVar275))) + ( ( (3f))));
				}
			}
			
			{
				Blackboards.personality subContext276 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext276 ContextSwitchInterpreter
				if(subContext276 != null)
				{
					
					System.Single OperandVar278 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop277 = subContext276.Brave; //IsContext = False IsNew = False
					OperandVar278 = prop277;
					
					
					subContext276.Brave = (System.Single)(( ( (OperandVar278))) + ( ( (0.2f))));
					
					System.Single OperandVar280 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop279 = subContext276.Optimistic; //IsContext = False IsNew = False
					OperandVar280 = prop279;
					
					
					subContext276.Optimistic = (System.Single)(( ( (OperandVar280))) + ( ( (0.5f))));
					
					System.Single OperandVar282 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop281 = subContext276.Ambitious; //IsContext = False IsNew = False
					OperandVar282 = prop281;
					
					
					subContext276.Ambitious = (System.Single)(( ( (OperandVar282))) + ( ( (0.2f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class taught_as_a_kid : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar289 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable283 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable283 != null)
			{
				Blackboards.personality StoredVariable284 = ((Blackboards.personality)StoredVariable283.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable284 != null)
				{
					Blackboards.aged StoredVariable285 = ((Blackboards.aged)StoredVariable284.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable285 != null)
					{
						System.Boolean ifResult286; //IsContext = False IsNew = False
						
						System.Int32 OperandVar288 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop287 = StoredVariable285.CurAge; //IsContext = False IsNew = False
						OperandVar288 = prop287;
						
						
						if(ifResult286 = ( ( (OperandVar288))) < ( ( (6f))))
						{
							applicable = true;
							OperandVar289 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar289);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.aged subContext290 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext290 ContextSwitchInterpreter
				if(subContext290 != null)
				{
					
					System.Int32 OperandVar292 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop291 = subContext290.CurAge; //IsContext = False IsNew = False
					OperandVar292 = prop291;
					
					
					subContext290.CurAge = (System.Int32)(( ( (OperandVar292))) + ( ( (3f))));
				}
			}
			
			{
				Blackboards.personality subContext293 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext293 ContextSwitchInterpreter
				if(subContext293 != null)
				{
					
					System.Single OperandVar295 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop294 = subContext293.Rational; //IsContext = False IsNew = False
					OperandVar295 = prop294;
					
					
					subContext293.Rational = (System.Single)(( ( (OperandVar295))) + ( ( (0.1f))));
					
					System.Single OperandVar297 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop296 = subContext293.Ambitious; //IsContext = False IsNew = False
					OperandVar297 = prop296;
					
					
					subContext293.Ambitious = (System.Single)(( ( (OperandVar297))) + ( ( (0.05f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class pushy_teen : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar304 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable298 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable298 != null)
			{
				Blackboards.personality StoredVariable299 = ((Blackboards.personality)StoredVariable298.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable299 != null)
				{
					Blackboards.aged StoredVariable300 = ((Blackboards.aged)StoredVariable299.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable300 != null)
					{
						System.Boolean ifResult301; //IsContext = False IsNew = False
						
						System.Int32 OperandVar303 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop302 = StoredVariable300.CurAge; //IsContext = False IsNew = False
						OperandVar303 = prop302;
						
						
						if(ifResult301 = ( ( (OperandVar303))) < ( ( (15f))))
						{
							applicable = true;
							OperandVar304 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar304);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			
			
			System.Single OperandVar307 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable305 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable305 != null)
			{
				System.Single prop306 = StoredVariable305.Brave; //IsContext = False IsNew = False
				OperandVar307 = prop306;
			}
			
			System.Single OperandVar309 = default(System.Single); //IsContext = False IsNew = False
			if(StoredVariable305 != null)
			{
				System.Single prop308 = StoredVariable305.Ambitious; //IsContext = False IsNew = False
				OperandVar309 = prop308;
			}
			
			System.Single OperandVar311 = default(System.Single); //IsContext = False IsNew = False
			if(StoredVariable305 != null)
			{
				System.Single prop310 = StoredVariable305.Cruel; //IsContext = False IsNew = False
				OperandVar311 = prop310;
			}
			return (System.Single)( ( (0.3f))) + ( ( (OperandVar307))) + ( ( (OperandVar309))) - ( ( (OperandVar311)));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.aged subContext312 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext312 ContextSwitchInterpreter
				if(subContext312 != null)
				{
					
					System.Int32 OperandVar314 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop313 = subContext312.CurAge; //IsContext = False IsNew = False
					OperandVar314 = prop313;
					
					System.Single OperandVar316 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop315 = External.Random( (3f), (5f)); //IsContext = False IsNew = False
					OperandVar316 = prop315;
					subContext312.CurAge = (System.Int32)(( ( (OperandVar314))) + ( ( (OperandVar316))));
				}
			}
			
			{
				Blackboards.personality subContext317 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext317 ContextSwitchInterpreter
				if(subContext317 != null)
				{
					
					System.Single OperandVar319 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop318 = subContext317.Brave; //IsContext = False IsNew = False
					OperandVar319 = prop318;
					
					
					subContext317.Brave = (System.Single)(( ( (OperandVar319))) + ( ( (0.3f))));
					
					System.Single OperandVar321 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop320 = subContext317.Rational; //IsContext = False IsNew = False
					OperandVar321 = prop320;
					
					
					subContext317.Rational = (System.Single)(( ( (OperandVar321))) - ( ( (0.1f))));
					
					System.Single OperandVar323 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop322 = subContext317.Optimistic; //IsContext = False IsNew = False
					OperandVar323 = prop322;
					
					
					subContext317.Optimistic = (System.Single)(( ( (OperandVar323))) + ( ( (0.3f))));
					
					System.Single OperandVar325 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop324 = subContext317.Ambitious; //IsContext = False IsNew = False
					OperandVar325 = prop324;
					
					
					subContext317.Ambitious = (System.Single)(( ( (OperandVar325))) + ( ( (0.1f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class nerd_teen : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar332 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable326 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable326 != null)
			{
				Blackboards.personality StoredVariable327 = ((Blackboards.personality)StoredVariable326.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable327 != null)
				{
					Blackboards.aged StoredVariable328 = ((Blackboards.aged)StoredVariable327.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable328 != null)
					{
						System.Boolean ifResult329; //IsContext = False IsNew = False
						
						System.Int32 OperandVar331 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop330 = StoredVariable328.CurAge; //IsContext = False IsNew = False
						OperandVar331 = prop330;
						
						
						if(ifResult329 = ( ( (OperandVar331))) < ( ( (15f))))
						{
							applicable = true;
							OperandVar332 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar332);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			
			
			System.Single OperandVar335 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable333 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable333 != null)
			{
				System.Single prop334 = StoredVariable333.Rational; //IsContext = False IsNew = False
				OperandVar335 = prop334;
			}
			
			System.Single OperandVar337 = default(System.Single); //IsContext = False IsNew = False
			if(StoredVariable333 != null)
			{
				System.Single prop336 = StoredVariable333.Brave; //IsContext = False IsNew = False
				OperandVar337 = prop336;
			}
			return (System.Single)( ( (0.3f))) + ( ( (OperandVar335))) - ( ( (OperandVar337)));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.aged subContext338 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext338 ContextSwitchInterpreter
				if(subContext338 != null)
				{
					
					System.Int32 OperandVar340 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop339 = subContext338.CurAge; //IsContext = False IsNew = False
					OperandVar340 = prop339;
					
					System.Single OperandVar342 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop341 = External.Random( (3f), (5f)); //IsContext = False IsNew = False
					OperandVar342 = prop341;
					subContext338.CurAge = (System.Int32)(( ( (OperandVar340))) + ( ( (OperandVar342))));
				}
			}
			
			{
				Blackboards.personality subContext343 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext343 ContextSwitchInterpreter
				if(subContext343 != null)
				{
					
					System.Single OperandVar345 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop344 = subContext343.Brave; //IsContext = False IsNew = False
					OperandVar345 = prop344;
					
					
					subContext343.Brave = (System.Single)(( ( (OperandVar345))) - ( ( (0.1f))));
					
					System.Single OperandVar347 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop346 = subContext343.Rational; //IsContext = False IsNew = False
					OperandVar347 = prop346;
					
					
					subContext343.Rational = (System.Single)(( ( (OperandVar347))) + ( ( (0.5f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class manipulative_teen : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar354 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable348 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable348 != null)
			{
				Blackboards.personality StoredVariable349 = ((Blackboards.personality)StoredVariable348.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable349 != null)
				{
					Blackboards.aged StoredVariable350 = ((Blackboards.aged)StoredVariable349.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable350 != null)
					{
						System.Boolean ifResult351; //IsContext = False IsNew = False
						
						System.Int32 OperandVar353 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop352 = StoredVariable350.CurAge; //IsContext = False IsNew = False
						OperandVar353 = prop352;
						
						
						if(ifResult351 = ( ( (OperandVar353))) < ( ( (15f))))
						{
							applicable = true;
							OperandVar354 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar354);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			
			
			System.Single OperandVar357 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable355 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable355 != null)
			{
				System.Single prop356 = StoredVariable355.Rational; //IsContext = False IsNew = False
				OperandVar357 = prop356;
			}
			
			System.Single OperandVar359 = default(System.Single); //IsContext = False IsNew = False
			if(StoredVariable355 != null)
			{
				System.Single prop358 = StoredVariable355.Ambitious; //IsContext = False IsNew = False
				OperandVar359 = prop358;
			}
			return (System.Single)( ( (0.2f))) + ( ( (OperandVar357))) + ( ( (OperandVar359)));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.aged subContext360 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext360 ContextSwitchInterpreter
				if(subContext360 != null)
				{
					
					System.Int32 OperandVar362 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop361 = subContext360.CurAge; //IsContext = False IsNew = False
					OperandVar362 = prop361;
					
					System.Single OperandVar364 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop363 = External.Random( (3f), (5f)); //IsContext = False IsNew = False
					OperandVar364 = prop363;
					subContext360.CurAge = (System.Int32)(( ( (OperandVar362))) + ( ( (OperandVar364))));
				}
			}
			
			{
				Blackboards.personality subContext365 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext365 ContextSwitchInterpreter
				if(subContext365 != null)
				{
					
					System.Single OperandVar367 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop366 = subContext365.Brave; //IsContext = False IsNew = False
					OperandVar367 = prop366;
					
					
					subContext365.Brave = (System.Single)(( ( (OperandVar367))) - ( ( (0.2f))));
					
					System.Single OperandVar369 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop368 = subContext365.Ambitious; //IsContext = False IsNew = False
					OperandVar369 = prop368;
					
					
					subContext365.Ambitious = (System.Single)(( ( (OperandVar369))) + ( ( (0.3f))));
					
					System.Single OperandVar371 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop370 = subContext365.Reckless; //IsContext = False IsNew = False
					OperandVar371 = prop370;
					
					
					subContext365.Reckless = (System.Single)(( ( (OperandVar371))) + ( ( (0.2f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class tortured_pets_teen : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar378 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable372 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable372 != null)
			{
				Blackboards.personality StoredVariable373 = ((Blackboards.personality)StoredVariable372.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable373 != null)
				{
					Blackboards.aged StoredVariable374 = ((Blackboards.aged)StoredVariable373.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable374 != null)
					{
						System.Boolean ifResult375; //IsContext = False IsNew = False
						
						System.Int32 OperandVar377 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop376 = StoredVariable374.CurAge; //IsContext = False IsNew = False
						OperandVar377 = prop376;
						
						
						if(ifResult375 = ( ( (OperandVar377))) < ( ( (15f))))
						{
							applicable = true;
							OperandVar378 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar378);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			System.Single OperandVar381 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable379 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable379 != null)
			{
				System.Single prop380 = StoredVariable379.Cruel; //IsContext = False IsNew = False
				OperandVar381 = prop380;
			}
			
			return (System.Single)( (OperandVar381)) * ( (0.8f));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.aged subContext382 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext382 ContextSwitchInterpreter
				if(subContext382 != null)
				{
					
					System.Int32 OperandVar384 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop383 = subContext382.CurAge; //IsContext = False IsNew = False
					OperandVar384 = prop383;
					
					System.Single OperandVar386 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop385 = External.Random( (3f), (5f)); //IsContext = False IsNew = False
					OperandVar386 = prop385;
					subContext382.CurAge = (System.Int32)(( ( (OperandVar384))) + ( ( (OperandVar386))));
				}
			}
			
			{
				Blackboards.personality subContext387 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext387 ContextSwitchInterpreter
				if(subContext387 != null)
				{
					
					System.Single OperandVar389 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop388 = subContext387.Rational; //IsContext = False IsNew = False
					OperandVar389 = prop388;
					
					
					subContext387.Rational = (System.Single)(( ( (OperandVar389))) - ( ( (0.1f))));
					
					System.Single OperandVar391 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop390 = subContext387.Cruel; //IsContext = False IsNew = False
					OperandVar391 = prop390;
					
					
					subContext387.Cruel = (System.Single)(( ( (OperandVar391))) + ( ( (0.5f))));
					
					System.Single OperandVar393 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop392 = subContext387.Reckless; //IsContext = False IsNew = False
					OperandVar393 = prop392;
					
					
					subContext387.Reckless = (System.Single)(( ( (OperandVar393))) + ( ( (0.5f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class named_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar407 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable394 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable394 != null)
			{
				Markers StoredVariable395 = ((Markers)StoredVariable394.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable395 != null)
				{
					System.Boolean ifResult396; //IsContext = False IsNew = False
					
					System.Boolean OperandVar403 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable394 != null)
					{
						UnityEngine.GameObject prop397 = StoredVariable394.ShowedObject; //IsContext = False IsNew = False
						if(prop397 != null)
						{
							System.Boolean ifResult398; //IsContext = False IsNew = False
							System.Boolean OperandVar402 = default(System.Boolean); //IsContext = False IsNew = False
							Named OperandVar400 = default(Named); //IsContext = False IsNew = False
							Named StoredVariable399 = ((Named)prop397.GetComponent(typeof(Named))); //IsContext = False IsNew = False
							if(StoredVariable399 != null)
							{
								OperandVar400 = StoredVariable399;
							}
							System.Boolean prop401 = External.Has( (OperandVar400)); //IsContext = False IsNew = False
							OperandVar402 = prop401;
							if(ifResult398 =  (OperandVar402))
							{
								OperandVar403 = ifResult398;
							}
						}
					}
					
					System.Boolean OperandVar406 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar404 = default(System.String); //IsContext = False IsNew = False
					OperandVar404 = "named_ui_marker";
					System.Boolean prop405 = StoredVariable395.HasMarker( (OperandVar404)); //IsContext = False IsNew = False
					OperandVar406 = prop405;
					if(ifResult396 = ( ( (OperandVar403))) && ( (!(OperandVar406))))
					{
						applicable = true;
						OperandVar407 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar407);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject OperandVar408 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar408 = root;
			UnityEngine.GameObject ctx =  (OperandVar408); //IsContext = False IsNew = False
			
			{
				BarsManager subContext409 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext409 ContextSwitchInterpreter
				if(subContext409 != null)
				{
					UnityEngine.GameObject OperandVar411 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop410 = subContext409.GetLeftBar(); //IsContext = False IsNew = False
					if(prop410 != null)
					{
						OperandVar411 = prop410;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar411); //IsContext = False IsNew = False
					
					{
						UnityEngine.GameObject subContext412 = p_ctx; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext412 ContextPropertySwitchInterpreter
						if(subContext412 != null)
						{
							System.Boolean OperandVar416 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar414 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable413 = ((UiObject)subContext412.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable413 != null)
							{
								OperandVar414 = StoredVariable413;
							}
							System.Boolean prop415 = External.Has( (OperandVar414)); //IsContext = False IsNew = False
							OperandVar416 = prop415;
							if( (OperandVar416))
							{
								UnityEngine.GameObject OperandVar417 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar417 = p_ctx;
								ctx =  (OperandVar417);
							}
						}
					}
				}
			}
			
			{
				Markers subContext418 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext418 ContextSwitchInterpreter
				if(subContext418 != null)
				{
					System.String OperandVar419 = default(System.String); //IsContext = False IsNew = False
					OperandVar419 = "named_ui_marker";
					subContext418.SetUiMarker(( (OperandVar419)).ToString());
				}
			}
			
			{
				UnityEngine.GameObject subContext420 = ctx; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext420 ContextPropertySwitchInterpreter
				if(subContext420 != null)
				{
					
					{
						UiObject subContext421 = (UiObject)subContext420.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
						//ContextStatement UiObject subContext421 ContextSwitchInterpreter
						if(subContext421 != null)
						{
							Named OperandVar424 = default(Named); //IsContext = False IsNew = False
							UnityEngine.GameObject prop422 = subContext421.ShowedObject; //IsContext = False IsNew = False
							if(prop422 != null)
							{
								Named StoredVariable423 = ((Named)prop422.GetComponent(typeof(Named))); //IsContext = False IsNew = False
								if(StoredVariable423 != null)
								{
									OperandVar424 = StoredVariable423;
								}
							}
							Named showed_named =  (OperandVar424); //IsContext = False IsNew = False
							TextField ContextVar425 = subContext420.AddComponent<TextField>();; //IsContext = False IsNew = True
							
							{
								//ContextStatement TextField ContextVar425 ContextSwitchInterpreter
								if(ContextVar425 != null)
								{
									System.String OperandVar427 = default(System.String); //IsContext = False IsNew = False
									System.String prop426 = showed_named.FullName; //IsContext = False IsNew = False
									if(prop426 != null)
									{
										OperandVar427 = prop426;
									}
									ContextVar425.Show(( (OperandVar427)).ToString());
									
									{
										//ContextStatement Named showed_named ContextSwitchInterpreter
										if(showed_named != null)
										{
											VoidDelegate Lambda428 = () => 
											{
												System.String OperandVar430 = default(System.String); //IsContext = False IsNew = False
												System.String prop429 = showed_named.FullName; //IsContext = False IsNew = False
												if(prop429 != null)
												{
													OperandVar430 = prop429;
												}
												ContextVar425.Show(( (OperandVar430)).ToString());
											};
											showed_named.OnUpdate(Lambda428);
										}
									}
									
									{
										UnityEngine.UI.LayoutElement subContext431 = ContextVar425.Layout; //IsContext = True IsNew = False
										//ContextStatement UnityEngine.UI.LayoutElement subContext431 ContextPropertySwitchInterpreter
										if(subContext431 != null)
										{
											
											subContext431.minHeight = (System.Single)( (20f));
										}
									}
									
									{
										UnityEngine.UI.LayoutElement subContext432 = ContextVar425.Layout; //IsContext = True IsNew = False
										//ContextStatement UnityEngine.UI.LayoutElement subContext432 ContextPropertySwitchInterpreter
										if(subContext432 != null)
										{
											
											subContext432.minWidth = (System.Single)( (100f));
										}
									}
								}
							}
							Entity EntVar433 = (Entity)subContext420.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
							if(EntVar433 != null) EntVar433.ComponentAdded();
						}
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class agents_pool_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar442 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable434 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable434 != null)
			{
				Place StoredVariable435 = ((Place)StoredVariable434.GetComponent(typeof(Place))); //IsContext = False IsNew = False
				if(StoredVariable435 != null)
				{
					System.Boolean ifResult436; //IsContext = False IsNew = False
					
					
					System.Collections.Generic.List<Agent> OperandVar438 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
					System.Collections.Generic.List<Agent> prop437 = StoredVariable435.Agents; //IsContext = False IsNew = False
					if(prop437 != null)
					{
						OperandVar438 = prop437;
					}
					
					
					
					System.Boolean OperandVar441 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar439 = default(System.String); //IsContext = False IsNew = False
					OperandVar439 = "agents_pool";
					System.Boolean prop440 = StoredVariable434.HasMarker( (OperandVar439)); //IsContext = False IsNew = False
					OperandVar441 = prop440;
					if(ifResult436 = ( (( ( (OperandVar438 != null ? OperandVar438.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar441))))
					{
						applicable = true;
						OperandVar442 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar442);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Place subContext443 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext443 ContextSwitchInterpreter
				if(subContext443 != null)
				{
					
					subContext443.Size = (System.Int32)( (5f));
					System.Single OperandVar445 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop444 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar445 = prop444;
					for (int i = 0; i <  (OperandVar445); i++)
					{
						UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject ag446 = ag; //IsContext = True IsNew = False
							Entity AddContext447 = (Entity)ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext448 = (Agent)ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.human AddContext449 = (Blackboards.human)ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext449 ContextSwitchInterpreter
								if(AddContext449 != null)
								{
									System.Single OperandVar451 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop450 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar451 = prop450;
									AddContext449.Age = (System.Int32)( (OperandVar451));
								}
							}
							Named AddContext452 = (Named)ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext452 ContextSwitchInterpreter
								if(AddContext452 != null)
								{
									
									
									
									AddContext452.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Agent: ")).ToString());
									
									
									System.String OperandVar455 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar453 = default(System.String); //IsContext = False IsNew = False
									OperandVar453 = "human_name";
									System.String prop454 = External.RandomName( (OperandVar453)); //IsContext = False IsNew = False
									if(prop454 != null)
									{
										OperandVar455 = prop454;
									}
									AddContext452.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar455)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag, 0.1f);
						Agent OperandVar457 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable456 = ((Agent)ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable456 != null)
						{
							OperandVar457 = StoredVariable456;
						}
						subContext443.Attach((Agent)( (OperandVar457)));
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class location_event : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar464 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable458 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable458 != null)
			{
				System.Boolean ifResult459; //IsContext = False IsNew = False
				System.Boolean OperandVar463 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.event_marker OperandVar461 = default(Blackboards.event_marker); //IsContext = False IsNew = False
				Blackboards.event_marker StoredVariable460 = ((Blackboards.event_marker)StoredVariable458.GetComponent(typeof(Blackboards.event_marker))); //IsContext = False IsNew = False
				if(StoredVariable460 != null)
				{
					OperandVar461 = StoredVariable460;
				}
				System.Boolean prop462 = External.Has( (OperandVar461)); //IsContext = False IsNew = False
				OperandVar463 = prop462;
				if(ifResult459 = !(OperandVar463))
				{
					applicable = true;
					OperandVar464 = applicable;
				}
			}
			return (System.Boolean) (OperandVar464);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.event_marker>();
			Entity EntVar465 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar465 != null) EntVar465.ComponentAdded();
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class map_anchored : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar467 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable466 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable466 != null)
			{
				applicable = true;
				OperandVar467 = applicable;
			}
			return (System.Boolean) (OperandVar467);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject OperandVar468 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar468 = root;
			External.MapEnlistDetailed((UnityEngine.GameObject)( (OperandVar468)));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class encounter_ui_enlist : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar475 = default(System.Boolean); //IsContext = False IsNew = False
			Encounter StoredVariable469 = ((Encounter)root.GetComponent(typeof(Encounter))); //IsContext = False IsNew = False
			if(StoredVariable469 != null)
			{
				Markers StoredVariable470 = ((Markers)StoredVariable469.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable470 != null)
				{
					System.Boolean ifResult471; //IsContext = False IsNew = False
					System.Boolean OperandVar474 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar472 = default(System.String); //IsContext = False IsNew = False
					OperandVar472 = "encounter_ui_enlist";
					System.Boolean prop473 = StoredVariable470.HasMarker( (OperandVar472)); //IsContext = False IsNew = False
					OperandVar474 = prop473;
					if(ifResult471 = !(OperandVar474))
					{
						applicable = true;
						OperandVar475 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar475);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext476 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext476 ContextSwitchInterpreter
				if(subContext476 != null)
				{
					System.String OperandVar477 = default(System.String); //IsContext = False IsNew = False
					OperandVar477 = "encounter_ui_enlist";
					subContext476.SetUiMarker(( (OperandVar477)).ToString());
				}
			}
			UnityEngine.GameObject OperandVar478 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar478 = root;
			External.EnlistEncounter((UnityEngine.GameObject)( (OperandVar478)));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class location_test_encounter : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar484 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable479 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable479 != null)
			{
				Named StoredVariable480 = ((Named)StoredVariable479.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable480 != null)
				{
					System.Boolean ifResult481; //IsContext = False IsNew = False
					
					System.Boolean OperandVar483 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable479 != null)
					{
						System.Boolean prop482 = StoredVariable479.Act; //IsContext = False IsNew = False
						OperandVar483 = prop482;
					}
					
					
					if(ifResult481 = ( ( (OperandVar483))) == ( ( (true))))
					{
						applicable = true;
						OperandVar484 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar484);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.4f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject enc = new UnityEngine.GameObject("enc"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject enc485 = enc; //IsContext = True IsNew = False
				Encounter AddContext486 = (Encounter)enc.AddComponent(typeof(Encounter)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Encounter AddContext486 ContextSwitchInterpreter
					if(AddContext486 != null)
					{
						UnityEngine.GameObject OperandVar487 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar487 = root;
						AddContext486.Context = (UnityEngine.GameObject)( (OperandVar487));
					}
				}
				Markers AddContext488 = (Markers)enc.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				Entity AddContext489 = (Entity)enc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Named AddContext490 = (Named)enc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Named AddContext490 ContextSwitchInterpreter
					if(AddContext490 != null)
					{
						System.String OperandVar491 = default(System.String); //IsContext = False IsNew = False
						OperandVar491 = "main_name";
						
						
						AddContext490.Set(( (OperandVar491)).ToString(),(System.Single)( (0f)),( ("Basic encounter")).ToString());
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(enc, 0.1f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class place_ui_cards_list : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar505 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable492 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable492 != null)
			{
				Markers StoredVariable493 = ((Markers)StoredVariable492.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable493 != null)
				{
					System.Boolean ifResult494; //IsContext = False IsNew = False
					
					System.Boolean OperandVar501 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable492 != null)
					{
						UnityEngine.GameObject prop495 = StoredVariable492.ShowedObject; //IsContext = False IsNew = False
						if(prop495 != null)
						{
							System.Boolean ifResult496; //IsContext = False IsNew = False
							System.Boolean OperandVar500 = default(System.Boolean); //IsContext = False IsNew = False
							Place OperandVar498 = default(Place); //IsContext = False IsNew = False
							Place StoredVariable497 = ((Place)prop495.GetComponent(typeof(Place))); //IsContext = False IsNew = False
							if(StoredVariable497 != null)
							{
								OperandVar498 = StoredVariable497;
							}
							System.Boolean prop499 = External.Has( (OperandVar498)); //IsContext = False IsNew = False
							OperandVar500 = prop499;
							if(ifResult496 =  (OperandVar500))
							{
								OperandVar501 = ifResult496;
							}
						}
					}
					
					System.Boolean OperandVar504 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar502 = default(System.String); //IsContext = False IsNew = False
					OperandVar502 = "place_ui_cards_list";
					System.Boolean prop503 = StoredVariable493.HasMarker( (OperandVar502)); //IsContext = False IsNew = False
					OperandVar504 = prop503;
					if(ifResult494 = ( ( (OperandVar501))) && ( (!(OperandVar504))))
					{
						applicable = true;
						OperandVar505 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar505);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject OperandVar506 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar506 = root;
			UnityEngine.GameObject ctx =  (OperandVar506); //IsContext = False IsNew = False
			
			{
				BarsManager subContext507 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext507 ContextSwitchInterpreter
				if(subContext507 != null)
				{
					UnityEngine.GameObject OperandVar509 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop508 = subContext507.GetBottomBar(); //IsContext = False IsNew = False
					if(prop508 != null)
					{
						OperandVar509 = prop508;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar509); //IsContext = False IsNew = False
					
					{
						UnityEngine.GameObject subContext510 = p_ctx; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext510 ContextPropertySwitchInterpreter
						if(subContext510 != null)
						{
							System.Boolean OperandVar514 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar512 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable511 = ((UiObject)subContext510.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable511 != null)
							{
								OperandVar512 = StoredVariable511;
							}
							System.Boolean prop513 = External.Has( (OperandVar512)); //IsContext = False IsNew = False
							OperandVar514 = prop513;
							if( (OperandVar514))
							{
								UnityEngine.GameObject OperandVar515 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar515 = p_ctx;
								ctx =  (OperandVar515);
							}
						}
					}
				}
			}
			
			{
				Markers subContext516 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext516 ContextSwitchInterpreter
				if(subContext516 != null)
				{
					System.String OperandVar517 = default(System.String); //IsContext = False IsNew = False
					OperandVar517 = "place_ui_cards_list";
					subContext516.SetUiMarker(( (OperandVar517)).ToString());
				}
			}
			Place OperandVar521 = default(Place); //IsContext = False IsNew = False
			UiObject StoredVariable518 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable518 != null)
			{
				UnityEngine.GameObject prop519 = StoredVariable518.ShowedObject; //IsContext = False IsNew = False
				if(prop519 != null)
				{
					Place StoredVariable520 = ((Place)prop519.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable520 != null)
					{
						OperandVar521 = StoredVariable520;
					}
				}
			}
			Place pl =  (OperandVar521); //IsContext = False IsNew = False
			System.String OperandVar522 = default(System.String); //IsContext = False IsNew = False
			OperandVar522 = "place_cards";
			
			{
				UnityEngine.GameObject FuncCtx523 = External.SpawnPrefab(( (OperandVar522)).ToString());; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject FuncCtx523 ContextPropertySwitchInterpreter
				if(FuncCtx523 != null)
				{
					
					{
						AgentsUI subContext524 = (AgentsUI)FuncCtx523.GetComponent(typeof(AgentsUI)); //IsContext = True IsNew = False
						//ContextStatement AgentsUI subContext524 ContextSwitchInterpreter
						if(subContext524 != null)
						{
							Place OperandVar525 = default(Place); //IsContext = False IsNew = False
							OperandVar525 = pl;
							subContext524.TargetPlace = (Place)( (OperandVar525));
						}
					}
					
					{
						CardsHolderAgentsAdapter subContext526 = (CardsHolderAgentsAdapter)FuncCtx523.GetComponent(typeof(CardsHolderAgentsAdapter)); //IsContext = True IsNew = False
						//ContextStatement CardsHolderAgentsAdapter subContext526 ContextSwitchInterpreter
						if(subContext526 != null)
						{
							Place OperandVar527 = default(Place); //IsContext = False IsNew = False
							OperandVar527 = pl;
							subContext526.TargetPlace = (Place)( (OperandVar527));
						}
					}
					UnityEngine.GameObject OperandVar528 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar528 = FuncCtx523;
					UnityEngine.GameObject OperandVar529 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar529 = ctx;
					External.SetParent((UnityEngine.GameObject)( (OperandVar528)),(UnityEngine.GameObject)( (OperandVar529)));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="ui", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class place_ui_size : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar535 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable530 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable530 != null)
			{
				System.Boolean ifResult531; //IsContext = False IsNew = False
				System.Boolean OperandVar534 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop532 = StoredVariable530.ShowedObject; //IsContext = False IsNew = False
				if(prop532 != null)
				{
					Place StoredVariable533 = ((Place)prop532.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable533 != null)
					{
						applicable = true;
						OperandVar534 = applicable;
					}
				}
				if(ifResult531 =  (OperandVar534))
				{
					applicable = true;
					OperandVar535 = applicable;
				}
			}
			return (System.Boolean) (OperandVar535);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject OperandVar536 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar536 = root;
			UnityEngine.GameObject ctx =  (OperandVar536); //IsContext = False IsNew = False
			
			{
				BarsManager subContext537 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext537 ContextSwitchInterpreter
				if(subContext537 != null)
				{
					UnityEngine.GameObject OperandVar539 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop538 = subContext537.GetLeftBar(); //IsContext = False IsNew = False
					if(prop538 != null)
					{
						OperandVar539 = prop538;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar539); //IsContext = False IsNew = False
					
					{
						UnityEngine.GameObject subContext540 = p_ctx; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext540 ContextPropertySwitchInterpreter
						if(subContext540 != null)
						{
							System.Boolean OperandVar544 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar542 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable541 = ((UiObject)subContext540.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable541 != null)
							{
								OperandVar542 = StoredVariable541;
							}
							System.Boolean prop543 = External.Has( (OperandVar542)); //IsContext = False IsNew = False
							OperandVar544 = prop543;
							if( (OperandVar544))
							{
								UnityEngine.GameObject OperandVar545 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar545 = p_ctx;
								ctx =  (OperandVar545);
							}
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext546 = ctx; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext546 ContextPropertySwitchInterpreter
				if(subContext546 != null)
				{
					TextField ContextVar547 = subContext546.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar547 ContextSwitchInterpreter
						if(ContextVar547 != null)
						{
							
							ContextVar547.Label = (System.String)( ("size"));
							System.Int32 OperandVar552 = default(System.Int32); //IsContext = False IsNew = False
							UiObject StoredVariable548 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable548 != null)
							{
								UnityEngine.GameObject prop549 = StoredVariable548.ShowedObject; //IsContext = False IsNew = False
								if(prop549 != null)
								{
									Place StoredVariable550 = ((Place)prop549.GetComponent(typeof(Place))); //IsContext = False IsNew = False
									if(StoredVariable550 != null)
									{
										System.Int32 prop551 = StoredVariable550.Size; //IsContext = False IsNew = False
										OperandVar552 = prop551;
									}
								}
							}
							ContextVar547.Show(( (OperandVar552)).ToString());
							
							{
								UnityEngine.UI.LayoutElement subContext553 = ContextVar547.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext553 ContextPropertySwitchInterpreter
								if(subContext553 != null)
								{
									
									subContext553.minHeight = (System.Single)( (20f));
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext554 = ContextVar547.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext554 ContextPropertySwitchInterpreter
								if(subContext554 != null)
								{
									
									subContext554.minWidth = (System.Single)( (100f));
								}
							}
						}
					}
					Entity EntVar555 = (Entity)subContext546.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
					if(EntVar555 != null) EntVar555.ComponentAdded();
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="ui", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class interactables_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar565 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable556 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable556 != null)
			{
				System.Boolean ifResult557; //IsContext = False IsNew = False
				System.Boolean OperandVar564 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop558 = StoredVariable556.ShowedObject; //IsContext = False IsNew = False
				if(prop558 != null)
				{
					System.Boolean ifResult559; //IsContext = False IsNew = False
					System.Boolean OperandVar563 = default(System.Boolean); //IsContext = False IsNew = False
					Interactables OperandVar561 = default(Interactables); //IsContext = False IsNew = False
					Interactables StoredVariable560 = ((Interactables)prop558.GetComponent(typeof(Interactables))); //IsContext = False IsNew = False
					if(StoredVariable560 != null)
					{
						OperandVar561 = StoredVariable560;
					}
					System.Boolean prop562 = External.Has( (OperandVar561)); //IsContext = False IsNew = False
					OperandVar563 = prop562;
					if(ifResult559 =  (OperandVar563))
					{
						OperandVar564 = ifResult559;
					}
				}
				if(ifResult557 =  (OperandVar564))
				{
					applicable = true;
					OperandVar565 = applicable;
				}
			}
			return (System.Boolean) (OperandVar565);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject OperandVar566 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar566 = root;
			UnityEngine.GameObject ctx =  (OperandVar566); //IsContext = False IsNew = False
			
			{
				BarsManager subContext567 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext567 ContextSwitchInterpreter
				if(subContext567 != null)
				{
					UnityEngine.GameObject OperandVar569 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop568 = subContext567.GetTopBar(); //IsContext = False IsNew = False
					if(prop568 != null)
					{
						OperandVar569 = prop568;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar569); //IsContext = False IsNew = False
					
					{
						UnityEngine.GameObject subContext570 = p_ctx; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext570 ContextPropertySwitchInterpreter
						if(subContext570 != null)
						{
							System.Boolean OperandVar574 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar572 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable571 = ((UiObject)subContext570.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable571 != null)
							{
								OperandVar572 = StoredVariable571;
							}
							System.Boolean prop573 = External.Has( (OperandVar572)); //IsContext = False IsNew = False
							OperandVar574 = prop573;
							if( (OperandVar574))
							{
								UnityEngine.GameObject OperandVar575 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar575 = p_ctx;
								ctx =  (OperandVar575);
							}
						}
					}
				}
			}
			Interactables OperandVar579 = default(Interactables); //IsContext = False IsNew = False
			UiObject StoredVariable576 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable576 != null)
			{
				UnityEngine.GameObject prop577 = StoredVariable576.ShowedObject; //IsContext = False IsNew = False
				if(prop577 != null)
				{
					Interactables StoredVariable578 = ((Interactables)prop577.GetComponent(typeof(Interactables))); //IsContext = False IsNew = False
					if(StoredVariable578 != null)
					{
						OperandVar579 = StoredVariable578;
					}
				}
			}
			Interactables inter =  (OperandVar579); //IsContext = False IsNew = False
			System.String OperandVar580 = default(System.String); //IsContext = False IsNew = False
			OperandVar580 = "interactables_ui";
			
			{
				UnityEngine.GameObject FuncCtx581 = External.SpawnPrefab(( (OperandVar580)).ToString());; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject FuncCtx581 ContextPropertySwitchInterpreter
				if(FuncCtx581 != null)
				{
					
					{
						InteractablesUI subContext582 = (InteractablesUI)FuncCtx581.GetComponent(typeof(InteractablesUI)); //IsContext = True IsNew = False
						//ContextStatement InteractablesUI subContext582 ContextSwitchInterpreter
						if(subContext582 != null)
						{
							Interactables OperandVar583 = default(Interactables); //IsContext = False IsNew = False
							OperandVar583 = inter;
							subContext582.TargetInteractables = (Interactables)( (OperandVar583));
						}
					}
					UnityEngine.GameObject OperandVar584 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar584 = FuncCtx581;
					UnityEngine.GameObject OperandVar585 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar585 = ctx;
					External.SetParent((UnityEngine.GameObject)( (OperandVar584)),(UnityEngine.GameObject)( (OperandVar585)));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="ui", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class interactable_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar599 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable586 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable586 != null)
			{
				System.Boolean ifResult587; //IsContext = False IsNew = False
				
				System.Boolean OperandVar594 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop588 = StoredVariable586.ShowedObject; //IsContext = False IsNew = False
				if(prop588 != null)
				{
					System.Boolean ifResult589; //IsContext = False IsNew = False
					System.Boolean OperandVar593 = default(System.Boolean); //IsContext = False IsNew = False
					Interactable OperandVar591 = default(Interactable); //IsContext = False IsNew = False
					Interactable StoredVariable590 = ((Interactable)prop588.GetComponent(typeof(Interactable))); //IsContext = False IsNew = False
					if(StoredVariable590 != null)
					{
						OperandVar591 = StoredVariable590;
					}
					System.Boolean prop592 = External.Has( (OperandVar591)); //IsContext = False IsNew = False
					OperandVar593 = prop592;
					if(ifResult589 =  (OperandVar593))
					{
						OperandVar594 = ifResult589;
					}
				}
				
				System.Boolean OperandVar598 = default(System.Boolean); //IsContext = False IsNew = False
				SelectableMarker OperandVar596 = default(SelectableMarker); //IsContext = False IsNew = False
				SelectableMarker StoredVariable595 = ((SelectableMarker)StoredVariable586.GetComponent(typeof(SelectableMarker))); //IsContext = False IsNew = False
				if(StoredVariable595 != null)
				{
					OperandVar596 = StoredVariable595;
				}
				System.Boolean prop597 = External.Has( (OperandVar596)); //IsContext = False IsNew = False
				OperandVar598 = prop597;
				if(ifResult587 = ( ( (OperandVar594))) && ( (!(OperandVar598))))
				{
					applicable = true;
					OperandVar599 = applicable;
				}
			}
			return (System.Boolean) (OperandVar599);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			External.Log((System.Object)( ("interactable UI")));
			UnityEngine.GameObject OperandVar600 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar600 = root;
			UnityEngine.GameObject ctx =  (OperandVar600); //IsContext = False IsNew = False
			
			{
				BarsManager subContext601 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext601 ContextSwitchInterpreter
				if(subContext601 != null)
				{
					UnityEngine.GameObject OperandVar603 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop602 = subContext601.GetRightBar(); //IsContext = False IsNew = False
					if(prop602 != null)
					{
						OperandVar603 = prop602;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar603); //IsContext = False IsNew = False
					
					{
						UnityEngine.GameObject subContext604 = p_ctx; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext604 ContextPropertySwitchInterpreter
						if(subContext604 != null)
						{
							System.Boolean OperandVar608 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar606 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable605 = ((UiObject)subContext604.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable605 != null)
							{
								OperandVar606 = StoredVariable605;
							}
							System.Boolean prop607 = External.Has( (OperandVar606)); //IsContext = False IsNew = False
							OperandVar608 = prop607;
							if( (OperandVar608))
							{
								UnityEngine.GameObject OperandVar609 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar609 = p_ctx;
								ctx =  (OperandVar609);
							}
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext610 = ctx; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext610 ContextPropertySwitchInterpreter
				if(subContext610 != null)
				{
					System.String OperandVar611 = default(System.String); //IsContext = False IsNew = False
					OperandVar611 = "interactions_ui";
					
					{
						UnityEngine.GameObject FuncCtx612 = External.SpawnPrefab(( (OperandVar611)).ToString());; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject FuncCtx612 ContextPropertySwitchInterpreter
						if(FuncCtx612 != null)
						{
							
							{
								InteractableUI subContext613 = (InteractableUI)FuncCtx612.GetComponent(typeof(InteractableUI)); //IsContext = True IsNew = False
								//ContextStatement InteractableUI subContext613 ContextSwitchInterpreter
								if(subContext613 != null)
								{
									Interactable OperandVar617 = default(Interactable); //IsContext = False IsNew = False
									UiObject StoredVariable614 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
									if(StoredVariable614 != null)
									{
										UnityEngine.GameObject prop615 = StoredVariable614.ShowedObject; //IsContext = False IsNew = False
										if(prop615 != null)
										{
											Interactable StoredVariable616 = ((Interactable)prop615.GetComponent(typeof(Interactable))); //IsContext = False IsNew = False
											if(StoredVariable616 != null)
											{
												OperandVar617 = StoredVariable616;
											}
										}
									}
									subContext613.TargetInteractable = (Interactable)( (OperandVar617));
								}
							}
							UnityEngine.GameObject OperandVar618 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							OperandVar618 = FuncCtx612;
							UnityEngine.GameObject OperandVar619 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							OperandVar619 = ctx;
							External.SetParent((UnityEngine.GameObject)( (OperandVar618)),(UnityEngine.GameObject)( (OperandVar619)));
						}
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=true, Tooltip=("show this interactable object name to Debug console"), OnceInCategory=false)]
    public class interaction_log_name : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar622 = default(System.Boolean); //IsContext = False IsNew = False
			Interactable StoredVariable620 = ((Interactable)root.GetComponent(typeof(Interactable))); //IsContext = False IsNew = False
			if(StoredVariable620 != null)
			{
				Named StoredVariable621 = ((Named)StoredVariable620.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable621 != null)
				{
					applicable = true;
					OperandVar622 = applicable;
				}
			}
			return (System.Boolean) (OperandVar622);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			System.String OperandVar625 = default(System.String); //IsContext = False IsNew = False
			Named StoredVariable623 = ((Named)root.GetComponent(typeof(Named))); //IsContext = False IsNew = False
			if(StoredVariable623 != null)
			{
				System.String prop624 = StoredVariable623.FullName; //IsContext = False IsNew = False
				if(prop624 != null)
				{
					OperandVar625 = prop624;
				}
			}
			External.Log((System.Object)( (OperandVar625)));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class inquisitor_basic_resources : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar627 = default(System.Boolean); //IsContext = False IsNew = False
			InquisitorResources StoredVariable626 = ((InquisitorResources)root.GetComponent(typeof(InquisitorResources))); //IsContext = False IsNew = False
			if(StoredVariable626 != null)
			{
				applicable = true;
				OperandVar627 = applicable;
			}
			return (System.Boolean) (OperandVar627);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			External.Gold = (System.Int32)( (100f));
			
			External.Influence = (System.Int32)( (100f));
			
			External.Sanity = (System.Int32)( (0f));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class on_check_lose : EventAction {
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar636 = default(System.Boolean); //IsContext = False IsNew = False
			InquisitorResources StoredVariable628 = ((InquisitorResources)root.GetComponent(typeof(InquisitorResources))); //IsContext = False IsNew = False
			if(StoredVariable628 != null)
			{
				Markers StoredVariable629 = ((Markers)StoredVariable628.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable629 != null)
				{
					System.Boolean ifResult630; //IsContext = False IsNew = False
					
					
					System.Int32 OperandVar632 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop631 = External.CurrentDate(); //IsContext = False IsNew = False
					OperandVar632 = prop631;
					
					
					
					System.Boolean OperandVar635 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar633 = default(System.String); //IsContext = False IsNew = False
					OperandVar633 = "lost";
					System.Boolean prop634 = StoredVariable629.HasMarker( (OperandVar633)); //IsContext = False IsNew = False
					OperandVar635 = prop634;
					if(ifResult630 = ( (( ( (OperandVar632))) > ( ( (0f))))) && ( (!(OperandVar635))))
					{
						applicable = true;
						OperandVar636 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar636);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			System.Int32 OperandVar638 = default(System.Int32); //IsContext = False IsNew = False
			System.Int32 prop637 = External.Sanity; //IsContext = False IsNew = False
			OperandVar638 = prop637;
			
			
			if(( ( (OperandVar638))) == ( ( (0f))))
			{
				System.String OperandVar639 = default(System.String); //IsContext = False IsNew = False
				OperandVar639 = "you_in_the_cult_now";
				External.Lose(( (OperandVar639)).ToString());
				
				{
					Markers subContext640 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
					//ContextStatement Markers subContext640 ContextSwitchInterpreter
					if(subContext640 != null)
					{
						System.String OperandVar641 = default(System.String); //IsContext = False IsNew = False
						OperandVar641 = "lost";
						subContext640.SetMarker(( (OperandVar641)).ToString());
					}
				}
			}
			
			System.Int32 OperandVar643 = default(System.Int32); //IsContext = False IsNew = False
			System.Int32 prop642 = External.Influence; //IsContext = False IsNew = False
			OperandVar643 = prop642;
			
			
			if(( ( (OperandVar643))) == ( ( (0f))))
			{
				System.String OperandVar644 = default(System.String); //IsContext = False IsNew = False
				OperandVar644 = "they_fired_you";
				External.Lose(( (OperandVar644)).ToString());
				
				{
					Markers subContext645 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
					//ContextStatement Markers subContext645 ContextSwitchInterpreter
					if(subContext645 != null)
					{
						System.String OperandVar646 = default(System.String); //IsContext = False IsNew = False
						OperandVar646 = "lost";
						subContext645.SetMarker(( (OperandVar646)).ToString());
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class lose_encounter_explain : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar650 = default(System.Boolean); //IsContext = False IsNew = False
			EncounterUi StoredVariable647 = ((EncounterUi)root.GetComponent(typeof(EncounterUi))); //IsContext = False IsNew = False
			if(StoredVariable647 != null)
			{
				UnityEngine.GameObject prop648 = StoredVariable647.ShowedObject; //IsContext = False IsNew = False
				if(prop648 != null)
				{
					LostEvent StoredVariable649 = ((LostEvent)prop648.GetComponent(typeof(LostEvent))); //IsContext = False IsNew = False
					if(StoredVariable649 != null)
					{
						applicable = true;
						OperandVar650 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar650);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				EncounterUi subContext651 = (EncounterUi)root.GetComponent(typeof(EncounterUi)); //IsContext = True IsNew = False
				//ContextStatement EncounterUi subContext651 ContextSwitchInterpreter
				if(subContext651 != null)
				{
					System.String OperandVar656 = default(System.String); //IsContext = False IsNew = False
					EncounterUi StoredVariable652 = ((EncounterUi)subContext651.GetComponent(typeof(EncounterUi))); //IsContext = False IsNew = False
					if(StoredVariable652 != null)
					{
						UnityEngine.GameObject prop653 = StoredVariable652.ShowedObject; //IsContext = False IsNew = False
						if(prop653 != null)
						{
							LostEvent StoredVariable654 = ((LostEvent)prop653.GetComponent(typeof(LostEvent))); //IsContext = False IsNew = False
							if(StoredVariable654 != null)
							{
								System.String prop655 = StoredVariable654.Why; //IsContext = False IsNew = False
								if(prop655 != null)
								{
									OperandVar656 = prop655;
								}
							}
						}
					}
					subContext651.Description = (System.String)( (OperandVar656));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class win_encounter_explain : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar660 = default(System.Boolean); //IsContext = False IsNew = False
			EncounterUi StoredVariable657 = ((EncounterUi)root.GetComponent(typeof(EncounterUi))); //IsContext = False IsNew = False
			if(StoredVariable657 != null)
			{
				UnityEngine.GameObject prop658 = StoredVariable657.ShowedObject; //IsContext = False IsNew = False
				if(prop658 != null)
				{
					WinEvent StoredVariable659 = ((WinEvent)prop658.GetComponent(typeof(WinEvent))); //IsContext = False IsNew = False
					if(StoredVariable659 != null)
					{
						applicable = true;
						OperandVar660 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar660);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				EncounterUi subContext661 = (EncounterUi)root.GetComponent(typeof(EncounterUi)); //IsContext = True IsNew = False
				//ContextStatement EncounterUi subContext661 ContextSwitchInterpreter
				if(subContext661 != null)
				{
					System.String OperandVar666 = default(System.String); //IsContext = False IsNew = False
					EncounterUi StoredVariable662 = ((EncounterUi)subContext661.GetComponent(typeof(EncounterUi))); //IsContext = False IsNew = False
					if(StoredVariable662 != null)
					{
						UnityEngine.GameObject prop663 = StoredVariable662.ShowedObject; //IsContext = False IsNew = False
						if(prop663 != null)
						{
							WinEvent StoredVariable664 = ((WinEvent)prop663.GetComponent(typeof(WinEvent))); //IsContext = False IsNew = False
							if(StoredVariable664 != null)
							{
								System.String prop665 = StoredVariable664.Why; //IsContext = False IsNew = False
								if(prop665 != null)
								{
									OperandVar666 = prop665;
								}
							}
						}
					}
					subContext661.Description = (System.String)( (OperandVar666));
				}
			}
		}
        }
    }
}
