namespace generators {
    
    
    public class locations_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar4 = default(System.Boolean); //IsContext = False IsNew = False
			Space StoredVariable0 = ((Space)root.GetComponent(typeof(Space))); //IsContext = False IsNew = False
			if(StoredVariable0 != null)
			{
				System.Boolean ifResult1; //IsContext = False IsNew = False
				
				System.Collections.Generic.List<Place> OperandVar3 = default(System.Collections.Generic.List<Place>); //IsContext = False IsNew = False
				System.Collections.Generic.List<Place> prop2 = StoredVariable0.Places; //IsContext = False IsNew = False
				if(prop2 != null)
				{
					OperandVar3 = prop2;
				}
				
				
				if(ifResult1 = ( ( (OperandVar3 != null ? OperandVar3.Count : 0))) == ( ( (0f))))
				{
					applicable = true;
					OperandVar4 = applicable;
				}
			}
			return (System.Boolean) (OperandVar4);
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
				Space subContext5 = (Space)root.GetComponent(typeof(Space)); //IsContext = True IsNew = False
				//ContextStatement Space subContext5 ContextSwitchInterpreter
				if(subContext5 != null)
				{
					
					subContext5.Size = (System.Int32)( (5f));
					System.Single OperandVar7 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop6 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar7 = prop6;
					for (int i = 0; i <  (OperandVar7); i++)
					{
						UnityEngine.GameObject loc = new UnityEngine.GameObject("loc"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject loc8 = loc; //IsContext = True IsNew = False
							Entity AddContext9 = (Entity)loc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Entity AddContext9 ContextSwitchInterpreter
								if(AddContext9 != null)
								{
									UnityEngine.Vector3 OperandVar19 = default(UnityEngine.Vector3); //IsContext = False IsNew = False
									System.Single OperandVar13 = default(System.Single); //IsContext = False IsNew = False
									
									System.Int32 OperandVar11 = default(System.Int32); //IsContext = False IsNew = False
									System.Int32 prop10 = External.MapX(); //IsContext = False IsNew = False
									OperandVar11 = prop10;
									System.Single prop12 = External.Random( (0f), (OperandVar11)); //IsContext = False IsNew = False
									OperandVar13 = prop12;
									System.Single OperandVar17 = default(System.Single); //IsContext = False IsNew = False
									
									System.Int32 OperandVar15 = default(System.Int32); //IsContext = False IsNew = False
									System.Int32 prop14 = External.MapX(); //IsContext = False IsNew = False
									OperandVar15 = prop14;
									System.Single prop16 = External.Random( (0f), (OperandVar15)); //IsContext = False IsNew = False
									OperandVar17 = prop16;
									UnityEngine.Vector3 prop18 = External.Vec( (OperandVar13), (OperandVar17)); //IsContext = False IsNew = False
									OperandVar19 = prop18;
									AddContext9.Position = (UnityEngine.Vector3)( (OperandVar19));
								}
							}
							Place AddContext20 = (Place)loc.AddComponent(typeof(Place)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Place AddContext20 ContextSwitchInterpreter
								if(AddContext20 != null)
								{
									System.Single OperandVar22 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop21 = External.Random( (1f), (3f)); //IsContext = False IsNew = False
									OperandVar22 = prop21;
									AddContext20.Size = (System.Int32)( (OperandVar22));
								}
							}
							Markers AddContext23 = (Markers)loc.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Markers AddContext23 ContextSwitchInterpreter
								if(AddContext23 != null)
								{
									System.String OperandVar24 = default(System.String); //IsContext = False IsNew = False
									OperandVar24 = "history_place";
									AddContext23.SetMarker(( (OperandVar24)).ToString());
								}
							}
							Named AddContext25 = (Named)loc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext25 ContextSwitchInterpreter
								if(AddContext25 != null)
								{
									
									
									
									AddContext25.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Location of: ")).ToString());
									
									
									System.String OperandVar28 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar26 = default(System.String); //IsContext = False IsNew = False
									OperandVar26 = "human_name";
									System.String prop27 = External.RandomName( (OperandVar26)); //IsContext = False IsNew = False
									if(prop27 != null)
									{
										OperandVar28 = prop27;
									}
									AddContext25.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar28)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(loc);
						Place OperandVar30 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable29 = ((Place)loc.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable29 != null)
						{
							OperandVar30 = StoredVariable29;
						}
						subContext5.Attach((Place)( (OperandVar30)));
					}
				}
			}
		}
        }
    }
    
    public class named_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar44 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable31 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable31 != null)
			{
				Markers StoredVariable32 = ((Markers)StoredVariable31.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable32 != null)
				{
					System.Boolean ifResult33; //IsContext = False IsNew = False
					
					System.Boolean OperandVar40 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable31 != null)
					{
						UnityEngine.GameObject prop34 = StoredVariable31.ShowedObject; //IsContext = False IsNew = False
						if(prop34 != null)
						{
							System.Boolean ifResult35; //IsContext = False IsNew = False
							System.Boolean OperandVar39 = default(System.Boolean); //IsContext = False IsNew = False
							Named OperandVar37 = default(Named); //IsContext = False IsNew = False
							Named StoredVariable36 = ((Named)prop34.GetComponent(typeof(Named))); //IsContext = False IsNew = False
							if(StoredVariable36 != null)
							{
								OperandVar37 = StoredVariable36;
							}
							System.Boolean prop38 = External.Has( (OperandVar37)); //IsContext = False IsNew = False
							OperandVar39 = prop38;
							if(ifResult35 =  (OperandVar39))
							{
								OperandVar40 = ifResult35;
							}
						}
					}
					
					System.Boolean OperandVar43 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar41 = default(System.String); //IsContext = False IsNew = False
					OperandVar41 = "named_ui_marker";
					System.Boolean prop42 = StoredVariable32.HasMarker( (OperandVar41)); //IsContext = False IsNew = False
					OperandVar43 = prop42;
					if(ifResult33 = ( ( (OperandVar40))) && ( (!(OperandVar43))))
					{
						applicable = true;
						OperandVar44 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar44);
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
				Markers subContext45 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext45 ContextSwitchInterpreter
				if(subContext45 != null)
				{
					System.String OperandVar46 = default(System.String); //IsContext = False IsNew = False
					OperandVar46 = "named_ui_marker";
					subContext45.SetUiMarker(( (OperandVar46)).ToString());
				}
			}
			
			{
				UiObject subContext47 = (UiObject)root.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
				//ContextStatement UiObject subContext47 ContextSwitchInterpreter
				if(subContext47 != null)
				{
					Named OperandVar50 = default(Named); //IsContext = False IsNew = False
					UnityEngine.GameObject prop48 = subContext47.ShowedObject; //IsContext = False IsNew = False
					if(prop48 != null)
					{
						Named StoredVariable49 = ((Named)prop48.GetComponent(typeof(Named))); //IsContext = False IsNew = False
						if(StoredVariable49 != null)
						{
							OperandVar50 = StoredVariable49;
						}
					}
					Named showed_named =  (OperandVar50); //IsContext = False IsNew = False
					TextField ContextVar51 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar51 ContextSwitchInterpreter
						if(ContextVar51 != null)
						{
							System.String OperandVar53 = default(System.String); //IsContext = False IsNew = False
							System.String prop52 = showed_named.FullName; //IsContext = False IsNew = False
							if(prop52 != null)
							{
								OperandVar53 = prop52;
							}
							ContextVar51.Show(( (OperandVar53)).ToString());
							
							{
								//ContextStatement Named showed_named ContextSwitchInterpreter
								if(showed_named != null)
								{
									VoidDelegate Lambda54 = () => 
									{
										System.String OperandVar56 = default(System.String); //IsContext = False IsNew = False
										System.String prop55 = showed_named.FullName; //IsContext = False IsNew = False
										if(prop55 != null)
										{
											OperandVar56 = prop55;
										}
										ContextVar51.Show(( (OperandVar56)).ToString());
									};
									showed_named.OnUpdate(Lambda54);
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext57 = ContextVar51.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext57 ContextPropertySwitchInterpreter
								if(subContext57 != null)
								{
									
									subContext57.minHeight = (System.Single)( (20f));
								}
							}
						}
					}
					Entity EntVar58 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
					if(EntVar58 != null) EntVar58.ComponentAdded();
				}
			}
		}
        }
    }
    
    public class agents_pool_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar67 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable59 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable59 != null)
			{
				Place StoredVariable60 = ((Place)StoredVariable59.GetComponent(typeof(Place))); //IsContext = False IsNew = False
				if(StoredVariable60 != null)
				{
					System.Boolean ifResult61; //IsContext = False IsNew = False
					
					
					System.Collections.Generic.List<Agent> OperandVar63 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
					System.Collections.Generic.List<Agent> prop62 = StoredVariable60.Agents; //IsContext = False IsNew = False
					if(prop62 != null)
					{
						OperandVar63 = prop62;
					}
					
					
					
					System.Boolean OperandVar66 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar64 = default(System.String); //IsContext = False IsNew = False
					OperandVar64 = "agents_pool";
					System.Boolean prop65 = StoredVariable59.HasMarker( (OperandVar64)); //IsContext = False IsNew = False
					OperandVar66 = prop65;
					if(ifResult61 = ( (( ( (OperandVar63 != null ? OperandVar63.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar66))))
					{
						applicable = true;
						OperandVar67 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar67);
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
				Place subContext68 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext68 ContextSwitchInterpreter
				if(subContext68 != null)
				{
					
					subContext68.Size = (System.Int32)( (5f));
					System.Single OperandVar70 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop69 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar70 = prop69;
					for (int i = 0; i <  (OperandVar70); i++)
					{
						UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject ag71 = ag; //IsContext = True IsNew = False
							Entity AddContext72 = (Entity)ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext73 = (Agent)ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.human AddContext74 = (Blackboards.human)ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext74 ContextSwitchInterpreter
								if(AddContext74 != null)
								{
									System.Single OperandVar76 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop75 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar76 = prop75;
									AddContext74.Age = (System.Int32)( (OperandVar76));
								}
							}
							Named AddContext77 = (Named)ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext77 ContextSwitchInterpreter
								if(AddContext77 != null)
								{
									
									
									
									AddContext77.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Agent: ")).ToString());
									
									
									System.String OperandVar80 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar78 = default(System.String); //IsContext = False IsNew = False
									OperandVar78 = "human_name";
									System.String prop79 = External.RandomName( (OperandVar78)); //IsContext = False IsNew = False
									if(prop79 != null)
									{
										OperandVar80 = prop79;
									}
									AddContext77.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar80)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag);
						Agent OperandVar82 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable81 = ((Agent)ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable81 != null)
						{
							OperandVar82 = StoredVariable81;
						}
						subContext68.Attach((Agent)( (OperandVar82)));
					}
				}
			}
		}
        }
    }
    
    public class location_event : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar89 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable83 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable83 != null)
			{
				System.Boolean ifResult84; //IsContext = False IsNew = False
				System.Boolean OperandVar88 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.event_marker OperandVar86 = default(Blackboards.event_marker); //IsContext = False IsNew = False
				Blackboards.event_marker StoredVariable85 = ((Blackboards.event_marker)StoredVariable83.GetComponent(typeof(Blackboards.event_marker))); //IsContext = False IsNew = False
				if(StoredVariable85 != null)
				{
					OperandVar86 = StoredVariable85;
				}
				System.Boolean prop87 = External.Has( (OperandVar86)); //IsContext = False IsNew = False
				OperandVar88 = prop87;
				if(ifResult84 = !(OperandVar88))
				{
					applicable = true;
					OperandVar89 = applicable;
				}
			}
			return (System.Boolean) (OperandVar89);
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
			Entity EntVar90 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar90 != null) EntVar90.ComponentAdded();
		}
        }
    }
    
    public class agent_personality : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar97 = default(System.Boolean); //IsContext = False IsNew = False
			Agent StoredVariable91 = ((Agent)root.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
			if(StoredVariable91 != null)
			{
				System.Boolean ifResult92; //IsContext = False IsNew = False
				System.Boolean OperandVar96 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.personality OperandVar94 = default(Blackboards.personality); //IsContext = False IsNew = False
				Blackboards.personality StoredVariable93 = ((Blackboards.personality)StoredVariable91.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable93 != null)
				{
					OperandVar94 = StoredVariable93;
				}
				System.Boolean prop95 = External.Has( (OperandVar94)); //IsContext = False IsNew = False
				OperandVar96 = prop95;
				if(ifResult92 = !(OperandVar96))
				{
					applicable = true;
					OperandVar97 = applicable;
				}
			}
			return (System.Boolean) (OperandVar97);
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
			
			root.AddComponent<Blackboards.personality>();
			Entity EntVar98 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar98 != null) EntVar98.ComponentAdded();
		}
        }
    }
    
    public class aged_generation_add : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar105 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.human StoredVariable99 = ((Blackboards.human)root.GetComponent(typeof(Blackboards.human))); //IsContext = False IsNew = False
			if(StoredVariable99 != null)
			{
				System.Boolean ifResult100; //IsContext = False IsNew = False
				System.Boolean OperandVar104 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.aged_generation OperandVar102 = default(Blackboards.aged_generation); //IsContext = False IsNew = False
				Blackboards.aged_generation StoredVariable101 = ((Blackboards.aged_generation)StoredVariable99.GetComponent(typeof(Blackboards.aged_generation))); //IsContext = False IsNew = False
				if(StoredVariable101 != null)
				{
					OperandVar102 = StoredVariable101;
				}
				System.Boolean prop103 = External.Has( (OperandVar102)); //IsContext = False IsNew = False
				OperandVar104 = prop103;
				if(ifResult100 = !(OperandVar104))
				{
					applicable = true;
					OperandVar105 = applicable;
				}
			}
			return (System.Boolean) (OperandVar105);
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
			
			root.AddComponent<Blackboards.aged_generation>();
			Entity EntVar106 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar106 != null) EntVar106.ComponentAdded();
		}
        }
    }
    
    public class historical_persons : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar116 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable107 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable107 != null)
			{
				Lore StoredVariable108 = ((Lore)StoredVariable107.GetComponent(typeof(Lore))); //IsContext = False IsNew = False
				if(StoredVariable108 != null)
				{
					Place StoredVariable109 = ((Place)StoredVariable108.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable109 != null)
					{
						System.Boolean ifResult110; //IsContext = False IsNew = False
						
						
						System.Collections.Generic.List<Agent> OperandVar112 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
						System.Collections.Generic.List<Agent> prop111 = StoredVariable109.Agents; //IsContext = False IsNew = False
						if(prop111 != null)
						{
							OperandVar112 = prop111;
						}
						
						
						
						System.Boolean OperandVar115 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar113 = default(System.String); //IsContext = False IsNew = False
						OperandVar113 = "lore_pool";
						System.Boolean prop114 = StoredVariable107.HasMarker( (OperandVar113)); //IsContext = False IsNew = False
						OperandVar115 = prop114;
						if(ifResult110 = ( (( ( (OperandVar112 != null ? OperandVar112.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar115))))
						{
							applicable = true;
							OperandVar116 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar116);
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
				Place subContext117 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext117 ContextSwitchInterpreter
				if(subContext117 != null)
				{
					
					subContext117.Size = (System.Int32)( (10f));
					System.Single OperandVar119 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop118 = External.Random( (4f), (10f)); //IsContext = False IsNew = False
					OperandVar119 = prop118;
					for (int i = 0; i <  (OperandVar119); i++)
					{
						UnityEngine.GameObject old_ag = new UnityEngine.GameObject("old_ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject old_ag120 = old_ag; //IsContext = True IsNew = False
							Entity AddContext121 = (Entity)old_ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext122 = (Agent)old_ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.historical_person AddContext123 = (Blackboards.historical_person)old_ag.AddComponent(typeof(Blackboards.historical_person)); //IsContext = True IsNew = True
							Blackboards.human AddContext124 = (Blackboards.human)old_ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext124 ContextSwitchInterpreter
								if(AddContext124 != null)
								{
									System.Single OperandVar126 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop125 = External.Random( (30f), (45f)); //IsContext = False IsNew = False
									OperandVar126 = prop125;
									AddContext124.Age = (System.Int32)( (OperandVar126));
								}
							}
							Named AddContext127 = (Named)old_ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext127 ContextSwitchInterpreter
								if(AddContext127 != null)
								{
									
									
									
									AddContext127.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Historical person: ")).ToString());
									
									
									System.String OperandVar130 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar128 = default(System.String); //IsContext = False IsNew = False
									OperandVar128 = "human_name";
									System.String prop129 = External.RandomName( (OperandVar128)); //IsContext = False IsNew = False
									if(prop129 != null)
									{
										OperandVar130 = prop129;
									}
									AddContext127.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar130)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(old_ag);
						Agent OperandVar132 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable131 = ((Agent)old_ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable131 != null)
						{
							OperandVar132 = StoredVariable131;
						}
						subContext117.Attach((Agent)( (OperandVar132)));
					}
				}
			}
		}
        }
    }
    
    public class location_log : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar138 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable133 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable133 != null)
			{
				Named StoredVariable134 = ((Named)StoredVariable133.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable134 != null)
				{
					System.Boolean ifResult135; //IsContext = False IsNew = False
					
					System.Boolean OperandVar137 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable133 != null)
					{
						System.Boolean prop136 = StoredVariable133.Act; //IsContext = False IsNew = False
						OperandVar137 = prop136;
					}
					
					
					if(ifResult135 = ( ( (OperandVar137))) == ( ( (true))))
					{
						applicable = true;
						OperandVar138 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar138);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.3f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			System.String OperandVar142 = default(System.String); //IsContext = False IsNew = False
			Named StoredVariable139 = ((Named)root.GetComponent(typeof(Named))); //IsContext = False IsNew = False
			if(StoredVariable139 != null)
			{
				System.String OperandVar140 = default(System.String); //IsContext = False IsNew = False
				OperandVar140 = "main_name";
				System.String prop141 = StoredVariable139.Get( (OperandVar140)); //IsContext = False IsNew = False
				if(prop141 != null)
				{
					OperandVar142 = prop141;
				}
			}
			External.Log((System.Object)( (OperandVar142)));
		}
        }
    }
    
    public class destroy_self : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar150 = default(System.Boolean); //IsContext = False IsNew = False
			Entity StoredVariable143 = ((Entity)root.GetComponent(typeof(Entity))); //IsContext = False IsNew = False
			if(StoredVariable143 != null)
			{
				Agent StoredVariable144 = ((Agent)StoredVariable143.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
				if(StoredVariable144 != null)
				{
					System.Boolean ifResult145; //IsContext = False IsNew = False
					
					
					System.Boolean OperandVar147 = default(System.Boolean); //IsContext = False IsNew = False
					System.Boolean prop146 = StoredVariable144.Act; //IsContext = False IsNew = False
					OperandVar147 = prop146;
					
					
					
					System.Boolean OperandVar149 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable143 != null)
					{
						System.Boolean prop148 = StoredVariable143.Dead; //IsContext = False IsNew = False
						OperandVar149 = prop148;
					}
					if(ifResult145 = ( (( ( (OperandVar147))) == ( ( (true))))) && ( (!(OperandVar149))))
					{
						applicable = true;
						OperandVar150 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar150);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.01f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			
			
			UnityEngine.GameObject OperandVar151 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar151 = root;
			External.Log((System.Object)(( ( ("Destroying self "))) + ( ( (OperandVar151)))));
			UnityEngine.GameObject OperandVar152 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar152 = root;
			External.Destroy((UnityEngine.Object)( (OperandVar152)));
		}
        }
    }
    
    public class story_start : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar161 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable153 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable153 != null)
			{
				System.Boolean ifResult154; //IsContext = False IsNew = False
				
				System.Boolean OperandVar157 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar155 = default(System.String); //IsContext = False IsNew = False
				OperandVar155 = "init_node";
				System.Boolean prop156 = StoredVariable153.HasMarker( (OperandVar155)); //IsContext = False IsNew = False
				OperandVar157 = prop156;
				
				System.Boolean OperandVar160 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar158 = default(System.String); //IsContext = False IsNew = False
				OperandVar158 = "story_set";
				System.Boolean prop159 = StoredVariable153.HasMarker( (OperandVar158)); //IsContext = False IsNew = False
				OperandVar160 = prop159;
				if(ifResult154 = ( ( (OperandVar157))) && ( (!(OperandVar160))))
				{
					applicable = true;
					OperandVar161 = applicable;
				}
			}
			return (System.Boolean) (OperandVar161);
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
				Markers subContext162 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext162 ContextSwitchInterpreter
				if(subContext162 != null)
				{
					System.String OperandVar163 = default(System.String); //IsContext = False IsNew = False
					OperandVar163 = "story_set";
					subContext162.SetMarker(( (OperandVar163)).ToString());
				}
			}
			UnityEngine.GameObject s_node = new UnityEngine.GameObject("s_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject s_node164 = s_node; //IsContext = True IsNew = False
				TaleNode AddContext165 = (TaleNode)s_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.story_node AddContext166 = (Blackboards.story_node)s_node.AddComponent(typeof(Blackboards.story_node)); //IsContext = True IsNew = True
				Entity AddContext167 = (Entity)s_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Markers AddContext168 = (Markers)s_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(s_node);
			
			{
				UnityEngine.GameObject subContext169 = s_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext169 ContextPropertySwitchInterpreter
				if(subContext169 != null)
				{
					
					{
						TaleNode subContext170 = (TaleNode)subContext169.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext170 ContextSwitchInterpreter
						if(subContext170 != null)
						{
							
							subContext170.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
		}
        }
    }
    
    public class story_basic_decomposition : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar180 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable171 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable171 != null)
			{
				Blackboards.story_node StoredVariable172 = ((Blackboards.story_node)StoredVariable171.GetComponent(typeof(Blackboards.story_node))); //IsContext = False IsNew = False
				if(StoredVariable172 != null)
				{
					TaleNode StoredVariable173 = ((TaleNode)StoredVariable172.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
					if(StoredVariable173 != null)
					{
						System.Boolean ifResult174; //IsContext = False IsNew = False
						
						System.Boolean OperandVar177 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar175 = default(System.String); //IsContext = False IsNew = False
						OperandVar175 = "decomposed";
						System.Boolean prop176 = StoredVariable171.HasMarker( (OperandVar175)); //IsContext = False IsNew = False
						OperandVar177 = prop176;
						
						System.Boolean OperandVar179 = default(System.Boolean); //IsContext = False IsNew = False
						System.Boolean prop178 = StoredVariable173.IsActive; //IsContext = False IsNew = False
						OperandVar179 = prop178;
						if(ifResult174 = ( (!(OperandVar177))) && ( ( (OperandVar179))))
						{
							applicable = true;
							OperandVar180 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar180);
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
				Markers subContext181 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext181 ContextSwitchInterpreter
				if(subContext181 != null)
				{
					System.String OperandVar182 = default(System.String); //IsContext = False IsNew = False
					OperandVar182 = "decomposed";
					subContext181.SetMarker(( (OperandVar182)).ToString());
				}
			}
			UnityEngine.GameObject c_node = new UnityEngine.GameObject("c_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject c_node183 = c_node; //IsContext = True IsNew = False
				Markers AddContext184 = (Markers)c_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext185 = (TaleNode)c_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Entity AddContext186 = (Entity)c_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Blackboards.conflict_node AddContext187 = (Blackboards.conflict_node)c_node.AddComponent(typeof(Blackboards.conflict_node)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(c_node);
			UnityEngine.GameObject c_r_node = new UnityEngine.GameObject("c_r_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject c_r_node188 = c_r_node; //IsContext = True IsNew = False
				Markers AddContext189 = (Markers)c_r_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext190 = (TaleNode)c_r_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Entity AddContext191 = (Entity)c_r_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Blackboards.conflict_resolution_node AddContext192 = (Blackboards.conflict_resolution_node)c_r_node.AddComponent(typeof(Blackboards.conflict_resolution_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.conflict_resolution_node AddContext192 ContextSwitchInterpreter
					if(AddContext192 != null)
					{
						UnityEngine.GameObject OperandVar193 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar193 = c_node;
						AddContext192.Conflict = (UnityEngine.GameObject)( (OperandVar193));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(c_r_node);
			UnityEngine.GameObject r_node = new UnityEngine.GameObject("r_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject r_node194 = r_node; //IsContext = True IsNew = False
				Markers AddContext195 = (Markers)r_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext196 = (TaleNode)r_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.result_node AddContext197 = (Blackboards.result_node)r_node.AddComponent(typeof(Blackboards.result_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.result_node AddContext197 ContextSwitchInterpreter
					if(AddContext197 != null)
					{
						UnityEngine.GameObject OperandVar198 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar198 = c_r_node;
						AddContext197.Resolution = (UnityEngine.GameObject)( (OperandVar198));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(r_node);
			UnityEngine.GameObject s_node = new UnityEngine.GameObject("s_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject s_node199 = s_node; //IsContext = True IsNew = False
				Markers AddContext200 = (Markers)s_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				Entity AddContext201 = (Entity)s_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				TaleNode AddContext202 = (TaleNode)s_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.solution_node AddContext203 = (Blackboards.solution_node)s_node.AddComponent(typeof(Blackboards.solution_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.solution_node AddContext203 ContextSwitchInterpreter
					if(AddContext203 != null)
					{
						UnityEngine.GameObject OperandVar204 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar204 = c_r_node;
						AddContext203.Cause = (UnityEngine.GameObject)( (OperandVar204));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(s_node);
			UnityEngine.GameObject cris_node = new UnityEngine.GameObject("cris_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject cris_node205 = cris_node; //IsContext = True IsNew = False
				Entity AddContext206 = (Entity)cris_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Markers AddContext207 = (Markers)cris_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext208 = (TaleNode)cris_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.crisis_node AddContext209 = (Blackboards.crisis_node)cris_node.AddComponent(typeof(Blackboards.crisis_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.crisis_node AddContext209 ContextSwitchInterpreter
					if(AddContext209 != null)
					{
						UnityEngine.GameObject OperandVar210 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar210 = s_node;
						AddContext209.Solution = (UnityEngine.GameObject)( (OperandVar210));
						UnityEngine.GameObject OperandVar211 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar211 = r_node;
						AddContext209.Cause = (UnityEngine.GameObject)( (OperandVar211));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(cris_node);
			
			{
				UnityEngine.GameObject subContext212 = c_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext212 ContextPropertySwitchInterpreter
				if(subContext212 != null)
				{
					
					{
						TaleNode subContext213 = (TaleNode)subContext212.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext213 ContextSwitchInterpreter
						if(subContext213 != null)
						{
							
							subContext213.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext214 = c_r_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext214 ContextPropertySwitchInterpreter
				if(subContext214 != null)
				{
					
					{
						TaleNode subContext215 = (TaleNode)subContext214.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext215 ContextSwitchInterpreter
						if(subContext215 != null)
						{
							
							subContext215.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext216 = r_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext216 ContextPropertySwitchInterpreter
				if(subContext216 != null)
				{
					
					{
						TaleNode subContext217 = (TaleNode)subContext216.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext217 ContextSwitchInterpreter
						if(subContext217 != null)
						{
							
							subContext217.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext218 = s_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext218 ContextPropertySwitchInterpreter
				if(subContext218 != null)
				{
					
					{
						TaleNode subContext219 = (TaleNode)subContext218.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext219 ContextSwitchInterpreter
						if(subContext219 != null)
						{
							
							subContext219.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext220 = cris_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext220 ContextPropertySwitchInterpreter
				if(subContext220 != null)
				{
					
					{
						TaleNode subContext221 = (TaleNode)subContext220.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext221 ContextSwitchInterpreter
						if(subContext221 != null)
						{
							
							subContext221.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
		}
        }
    }
    
    public class conflict_basic_decomposition : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar231 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable222 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable222 != null)
			{
				Blackboards.conflict_node StoredVariable223 = ((Blackboards.conflict_node)StoredVariable222.GetComponent(typeof(Blackboards.conflict_node))); //IsContext = False IsNew = False
				if(StoredVariable223 != null)
				{
					TaleNode StoredVariable224 = ((TaleNode)StoredVariable223.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
					if(StoredVariable224 != null)
					{
						System.Boolean ifResult225; //IsContext = False IsNew = False
						
						System.Boolean OperandVar228 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar226 = default(System.String); //IsContext = False IsNew = False
						OperandVar226 = "decomposed";
						System.Boolean prop227 = StoredVariable222.HasMarker( (OperandVar226)); //IsContext = False IsNew = False
						OperandVar228 = prop227;
						
						System.Boolean OperandVar230 = default(System.Boolean); //IsContext = False IsNew = False
						System.Boolean prop229 = StoredVariable224.IsActive; //IsContext = False IsNew = False
						OperandVar230 = prop229;
						if(ifResult225 = ( (!(OperandVar228))) && ( ( (OperandVar230))))
						{
							applicable = true;
							OperandVar231 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar231);
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
			
			
			for (int i = 0; i <  (2f); i++)
			{
				UnityEngine.GameObject f_node = new UnityEngine.GameObject("f_node"); //IsContext = False IsNew = False
				
				{
					UnityEngine.GameObject f_node232 = f_node; //IsContext = True IsNew = False
					TaleNode AddContext233 = (TaleNode)f_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
					Entity AddContext234 = (Entity)f_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
					Blackboards.faction_node AddContext235 = (Blackboards.faction_node)f_node.AddComponent(typeof(Blackboards.faction_node)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Blackboards.faction_node AddContext235 ContextSwitchInterpreter
						if(AddContext235 != null)
						{
							UnityEngine.GameObject OperandVar236 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							OperandVar236 = root;
							AddContext235.Conflict = (UnityEngine.GameObject)( (OperandVar236));
						}
					}
					Markers AddContext237 = (Markers)f_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				}
				UnityEngine.Object.FindObjectOfType<Generators>().Generate(f_node);
				
				{
					UnityEngine.GameObject subContext238 = f_node; //IsContext = True IsNew = False
					//ContextStatement UnityEngine.GameObject subContext238 ContextPropertySwitchInterpreter
					if(subContext238 != null)
					{
						
						{
							TaleNode subContext239 = (TaleNode)subContext238.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
							//ContextStatement TaleNode subContext239 ContextSwitchInterpreter
							if(subContext239 != null)
							{
								
								subContext239.IsActive = (System.Boolean)( (true));
							}
						}
					}
				}
			}
			
			{
				Markers subContext240 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext240 ContextSwitchInterpreter
				if(subContext240 != null)
				{
					System.String OperandVar241 = default(System.String); //IsContext = False IsNew = False
					OperandVar241 = "decomposed";
					subContext240.SetMarker(( (OperandVar241)).ToString());
				}
			}
		}
        }
    }
    
    public class faction_is_a_state : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar248 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.faction_node StoredVariable242 = ((Blackboards.faction_node)root.GetComponent(typeof(Blackboards.faction_node))); //IsContext = False IsNew = False
			if(StoredVariable242 != null)
			{
				Markers StoredVariable243 = ((Markers)StoredVariable242.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable243 != null)
				{
					System.Boolean ifResult244; //IsContext = False IsNew = False
					System.Boolean OperandVar247 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar245 = default(System.String); //IsContext = False IsNew = False
					OperandVar245 = "faction_is_a_state";
					System.Boolean prop246 = StoredVariable243.HasMarker( (OperandVar245)); //IsContext = False IsNew = False
					OperandVar247 = prop246;
					if(ifResult244 = !(OperandVar247))
					{
						applicable = true;
						OperandVar248 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar248);
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
			
			root.AddComponent<Blackboards.state_node>();
			Entity EntVar249 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar249 != null) EntVar249.ComponentAdded();
			
			{
				Markers subContext250 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext250 ContextSwitchInterpreter
				if(subContext250 != null)
				{
					System.String OperandVar251 = default(System.String); //IsContext = False IsNew = False
					OperandVar251 = "faction_is_a_state";
					subContext250.SetMarker(( (OperandVar251)).ToString());
				}
			}
		}
        }
    }
    
    public class state_name : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar258 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.state_node StoredVariable252 = ((Blackboards.state_node)root.GetComponent(typeof(Blackboards.state_node))); //IsContext = False IsNew = False
			if(StoredVariable252 != null)
			{
				System.Boolean ifResult253; //IsContext = False IsNew = False
				System.Boolean OperandVar257 = default(System.Boolean); //IsContext = False IsNew = False
				Named OperandVar255 = default(Named); //IsContext = False IsNew = False
				Named StoredVariable254 = ((Named)StoredVariable252.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable254 != null)
				{
					OperandVar255 = StoredVariable254;
				}
				System.Boolean prop256 = External.Has( (OperandVar255)); //IsContext = False IsNew = False
				OperandVar257 = prop256;
				if(ifResult253 = !(OperandVar257))
				{
					applicable = true;
					OperandVar258 = applicable;
				}
			}
			return (System.Boolean) (OperandVar258);
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
			
			Named ContextVar259 = root.AddComponent<Named>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement Named ContextVar259 ContextSwitchInterpreter
				if(ContextVar259 != null)
				{
					
					
					System.String OperandVar262 = default(System.String); //IsContext = False IsNew = False
					System.String OperandVar260 = default(System.String); //IsContext = False IsNew = False
					OperandVar260 = "country_name";
					System.String prop261 = External.RandomName( (OperandVar260)); //IsContext = False IsNew = False
					if(prop261 != null)
					{
						OperandVar262 = prop261;
					}
					ContextVar259.Set(( ("main_name")).ToString(),(System.Single)( (0f)),( (OperandVar262)).ToString());
				}
			}
			Entity EntVar263 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar263 != null) EntVar263.ComponentAdded();
		}
        }
    }
    
    public class state_head : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar273 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.state_node StoredVariable264 = ((Blackboards.state_node)root.GetComponent(typeof(Blackboards.state_node))); //IsContext = False IsNew = False
			if(StoredVariable264 != null)
			{
				TaleNode StoredVariable265 = ((TaleNode)StoredVariable264.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
				if(StoredVariable265 != null)
				{
					System.Boolean ifResult266; //IsContext = False IsNew = False
					
					System.Boolean OperandVar270 = default(System.Boolean); //IsContext = False IsNew = False
					UnityEngine.GameObject OperandVar268 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					if(StoredVariable264 != null)
					{
						UnityEngine.GameObject prop267 = StoredVariable264.Head; //IsContext = False IsNew = False
						if(prop267 != null)
						{
							OperandVar268 = prop267;
						}
					}
					System.Boolean prop269 = External.Has( (OperandVar268)); //IsContext = False IsNew = False
					OperandVar270 = prop269;
					
					System.Boolean OperandVar272 = default(System.Boolean); //IsContext = False IsNew = False
					System.Boolean prop271 = StoredVariable265.IsActive; //IsContext = False IsNew = False
					OperandVar272 = prop271;
					if(ifResult266 = ( (!(OperandVar270))) && ( ( (OperandVar272))))
					{
						applicable = true;
						OperandVar273 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar273);
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
				Blackboards.state_node subContext274 = (Blackboards.state_node)root.GetComponent(typeof(Blackboards.state_node)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.state_node subContext274 ContextSwitchInterpreter
				if(subContext274 != null)
				{
					UnityEngine.GameObject head_of_state = new UnityEngine.GameObject("head_of_state"); //IsContext = False IsNew = False
					
					{
						UnityEngine.GameObject head_of_state275 = head_of_state; //IsContext = True IsNew = False
						Markers AddContext276 = (Markers)head_of_state.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
						Blackboards.person_node AddContext277 = (Blackboards.person_node)head_of_state.AddComponent(typeof(Blackboards.person_node)); //IsContext = True IsNew = True
						TaleNode AddContext278 = (TaleNode)head_of_state.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
						Blackboards.head_of_state_node AddContext279 = (Blackboards.head_of_state_node)head_of_state.AddComponent(typeof(Blackboards.head_of_state_node)); //IsContext = True IsNew = True
						
						{
							//ContextStatement Blackboards.head_of_state_node AddContext279 ContextSwitchInterpreter
							if(AddContext279 != null)
							{
								UnityEngine.GameObject OperandVar280 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar280 = root;
								AddContext279.State = (UnityEngine.GameObject)( (OperandVar280));
							}
						}
						Entity AddContext281 = (Entity)head_of_state.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
					}
					UnityEngine.Object.FindObjectOfType<Generators>().Generate(head_of_state);
					
					{
						UnityEngine.GameObject subContext282 = head_of_state; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext282 ContextPropertySwitchInterpreter
						if(subContext282 != null)
						{
							
							{
								TaleNode subContext283 = (TaleNode)subContext282.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
								//ContextStatement TaleNode subContext283 ContextSwitchInterpreter
								if(subContext283 != null)
								{
									
									subContext283.IsActive = (System.Boolean)( (true));
								}
							}
						}
					}
					UnityEngine.GameObject OperandVar284 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar284 = head_of_state;
					subContext274.Head = (UnityEngine.GameObject)( (OperandVar284));
				}
			}
		}
        }
    }
    
    public class state_head_death : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar299 = default(System.Boolean); //IsContext = False IsNew = False
			Event StoredVariable285 = ((Event)root.GetComponent(typeof(Event))); //IsContext = False IsNew = False
			if(StoredVariable285 != null)
			{
				Markers StoredVariable286 = ((Markers)StoredVariable285.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable286 != null)
				{
					EntityDeathEvent StoredVariable287 = ((EntityDeathEvent)StoredVariable286.GetComponent(typeof(EntityDeathEvent))); //IsContext = False IsNew = False
					if(StoredVariable287 != null)
					{
						System.Boolean ifResult288; //IsContext = False IsNew = False
						
						System.Boolean OperandVar295 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable285 != null)
						{
							UnityEngine.GameObject prop289 = StoredVariable285.Context; //IsContext = False IsNew = False
							if(prop289 != null)
							{
								System.Boolean ifResult290; //IsContext = False IsNew = False
								System.Boolean OperandVar294 = default(System.Boolean); //IsContext = False IsNew = False
								Blackboards.head_of_state_node OperandVar292 = default(Blackboards.head_of_state_node); //IsContext = False IsNew = False
								Blackboards.head_of_state_node StoredVariable291 = ((Blackboards.head_of_state_node)prop289.GetComponent(typeof(Blackboards.head_of_state_node))); //IsContext = False IsNew = False
								if(StoredVariable291 != null)
								{
									OperandVar292 = StoredVariable291;
								}
								System.Boolean prop293 = External.Has( (OperandVar292)); //IsContext = False IsNew = False
								OperandVar294 = prop293;
								if(ifResult290 =  (OperandVar294))
								{
									OperandVar295 = ifResult290;
								}
							}
						}
						
						System.Boolean OperandVar298 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar296 = default(System.String); //IsContext = False IsNew = False
						OperandVar296 = "state_head_death_reacted";
						System.Boolean prop297 = StoredVariable286.HasMarker( (OperandVar296)); //IsContext = False IsNew = False
						OperandVar298 = prop297;
						if(ifResult288 = ( ( (OperandVar295))) && ( (!(OperandVar298))))
						{
							applicable = true;
							OperandVar299 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar299);
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
				Markers subContext300 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext300 ContextSwitchInterpreter
				if(subContext300 != null)
				{
					System.String OperandVar301 = default(System.String); //IsContext = False IsNew = False
					OperandVar301 = "state_head_death_reacted";
					subContext300.SetMarker(( (OperandVar301)).ToString());
				}
			}
			
			{
				Event subContext302 = (Event)root.GetComponent(typeof(Event)); //IsContext = True IsNew = False
				//ContextStatement Event subContext302 ContextSwitchInterpreter
				if(subContext302 != null)
				{
					
					{
						UnityEngine.GameObject subContext303 = subContext302.Context; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext303 ContextPropertySwitchInterpreter
						if(subContext303 != null)
						{
							
							{
								Blackboards.head_of_state_node subContext304 = (Blackboards.head_of_state_node)subContext303.GetComponent(typeof(Blackboards.head_of_state_node)); //IsContext = True IsNew = False
								//ContextStatement Blackboards.head_of_state_node subContext304 ContextSwitchInterpreter
								if(subContext304 != null)
								{
								}
							}
						}
					}
				}
			}
		}
        }
    }
    
    public class state_head_name : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar311 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.head_of_state_node StoredVariable305 = ((Blackboards.head_of_state_node)root.GetComponent(typeof(Blackboards.head_of_state_node))); //IsContext = False IsNew = False
			if(StoredVariable305 != null)
			{
				System.Boolean ifResult306; //IsContext = False IsNew = False
				System.Boolean OperandVar310 = default(System.Boolean); //IsContext = False IsNew = False
				Named OperandVar308 = default(Named); //IsContext = False IsNew = False
				Named StoredVariable307 = ((Named)StoredVariable305.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable307 != null)
				{
					OperandVar308 = StoredVariable307;
				}
				System.Boolean prop309 = External.Has( (OperandVar308)); //IsContext = False IsNew = False
				OperandVar310 = prop309;
				if(ifResult306 = !(OperandVar310))
				{
					applicable = true;
					OperandVar311 = applicable;
				}
			}
			return (System.Boolean) (OperandVar311);
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
			
			Named ContextVar312 = root.AddComponent<Named>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement Named ContextVar312 ContextSwitchInterpreter
				if(ContextVar312 != null)
				{
					System.String OperandVar313 = default(System.String); //IsContext = False IsNew = False
					OperandVar313 = "main_name";
					
					System.String OperandVar316 = default(System.String); //IsContext = False IsNew = False
					System.String OperandVar314 = default(System.String); //IsContext = False IsNew = False
					OperandVar314 = "human_name";
					System.String prop315 = External.RandomName( (OperandVar314)); //IsContext = False IsNew = False
					if(prop315 != null)
					{
						OperandVar316 = prop315;
					}
					ContextVar312.Set(( (OperandVar313)).ToString(),(System.Single)( (0f)),( (OperandVar316)).ToString());
				}
			}
			Entity EntVar317 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar317 != null) EntVar317.ComponentAdded();
		}
        }
    }
    
    public class map_anchored : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar327 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable318 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable318 != null)
			{
				Markers StoredVariable319 = ((Markers)StoredVariable318.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable319 != null)
				{
					System.Boolean ifResult320; //IsContext = False IsNew = False
					
					System.Boolean OperandVar323 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar321 = default(System.String); //IsContext = False IsNew = False
					OperandVar321 = "map_anchored";
					System.Boolean prop322 = StoredVariable319.HasMarker( (OperandVar321)); //IsContext = False IsNew = False
					OperandVar323 = prop322;
					
					System.Boolean OperandVar326 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar324 = default(System.String); //IsContext = False IsNew = False
					OperandVar324 = "history_place";
					System.Boolean prop325 = StoredVariable319.HasMarker( (OperandVar324)); //IsContext = False IsNew = False
					OperandVar326 = prop325;
					if(ifResult320 = ( (!(OperandVar323))) && ( ( (OperandVar326))))
					{
						applicable = true;
						OperandVar327 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar327);
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
				Markers subContext328 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext328 ContextSwitchInterpreter
				if(subContext328 != null)
				{
					System.String OperandVar329 = default(System.String); //IsContext = False IsNew = False
					OperandVar329 = "map_anchored";
					subContext328.SetUiMarker(( (OperandVar329)).ToString());
				}
			}
			UnityEngine.GameObject OperandVar330 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar330 = root;
			External.MapEnlist((UnityEngine.GameObject)( (OperandVar330)));
		}
        }
    }
    
    public class encounter_ui_enlist : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar337 = default(System.Boolean); //IsContext = False IsNew = False
			Encounter StoredVariable331 = ((Encounter)root.GetComponent(typeof(Encounter))); //IsContext = False IsNew = False
			if(StoredVariable331 != null)
			{
				Markers StoredVariable332 = ((Markers)StoredVariable331.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable332 != null)
				{
					System.Boolean ifResult333; //IsContext = False IsNew = False
					System.Boolean OperandVar336 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar334 = default(System.String); //IsContext = False IsNew = False
					OperandVar334 = "encounter_ui_enlist";
					System.Boolean prop335 = StoredVariable332.HasMarker( (OperandVar334)); //IsContext = False IsNew = False
					OperandVar336 = prop335;
					if(ifResult333 = !(OperandVar336))
					{
						applicable = true;
						OperandVar337 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar337);
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
				Markers subContext338 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext338 ContextSwitchInterpreter
				if(subContext338 != null)
				{
					System.String OperandVar339 = default(System.String); //IsContext = False IsNew = False
					OperandVar339 = "encounter_ui_enlist";
					subContext338.SetUiMarker(( (OperandVar339)).ToString());
				}
			}
			UnityEngine.GameObject OperandVar340 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar340 = root;
			External.EnlistEncounter((UnityEngine.GameObject)( (OperandVar340)));
		}
        }
    }
    
    public class location_test_encounter : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar346 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable341 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable341 != null)
			{
				Named StoredVariable342 = ((Named)StoredVariable341.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable342 != null)
				{
					System.Boolean ifResult343; //IsContext = False IsNew = False
					
					System.Boolean OperandVar345 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable341 != null)
					{
						System.Boolean prop344 = StoredVariable341.Act; //IsContext = False IsNew = False
						OperandVar345 = prop344;
					}
					
					
					if(ifResult343 = ( ( (OperandVar345))) == ( ( (true))))
					{
						applicable = true;
						OperandVar346 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar346);
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
				UnityEngine.GameObject enc347 = enc; //IsContext = True IsNew = False
				Encounter AddContext348 = (Encounter)enc.AddComponent(typeof(Encounter)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Encounter AddContext348 ContextSwitchInterpreter
					if(AddContext348 != null)
					{
						UnityEngine.GameObject OperandVar349 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar349 = root;
						AddContext348.Context = (UnityEngine.GameObject)( (OperandVar349));
					}
				}
				Markers AddContext350 = (Markers)enc.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				Entity AddContext351 = (Entity)enc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Named AddContext352 = (Named)enc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Named AddContext352 ContextSwitchInterpreter
					if(AddContext352 != null)
					{
						System.String OperandVar353 = default(System.String); //IsContext = False IsNew = False
						OperandVar353 = "main_name";
						
						
						AddContext352.Set(( (OperandVar353)).ToString(),(System.Single)( (0f)),( ("Basic encounter")).ToString());
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(enc);
		}
        }
    }
    
    public class place_ui_cards_list : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar367 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable354 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable354 != null)
			{
				Markers StoredVariable355 = ((Markers)StoredVariable354.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable355 != null)
				{
					System.Boolean ifResult356; //IsContext = False IsNew = False
					
					System.Boolean OperandVar363 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable354 != null)
					{
						UnityEngine.GameObject prop357 = StoredVariable354.ShowedObject; //IsContext = False IsNew = False
						if(prop357 != null)
						{
							System.Boolean ifResult358; //IsContext = False IsNew = False
							System.Boolean OperandVar362 = default(System.Boolean); //IsContext = False IsNew = False
							Place OperandVar360 = default(Place); //IsContext = False IsNew = False
							Place StoredVariable359 = ((Place)prop357.GetComponent(typeof(Place))); //IsContext = False IsNew = False
							if(StoredVariable359 != null)
							{
								OperandVar360 = StoredVariable359;
							}
							System.Boolean prop361 = External.Has( (OperandVar360)); //IsContext = False IsNew = False
							OperandVar362 = prop361;
							if(ifResult358 =  (OperandVar362))
							{
								OperandVar363 = ifResult358;
							}
						}
					}
					
					System.Boolean OperandVar366 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar364 = default(System.String); //IsContext = False IsNew = False
					OperandVar364 = "place_ui_cards_list";
					System.Boolean prop365 = StoredVariable355.HasMarker( (OperandVar364)); //IsContext = False IsNew = False
					OperandVar366 = prop365;
					if(ifResult356 = ( ( (OperandVar363))) && ( (!(OperandVar366))))
					{
						applicable = true;
						OperandVar367 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar367);
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
				Markers subContext368 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext368 ContextSwitchInterpreter
				if(subContext368 != null)
				{
					System.String OperandVar369 = default(System.String); //IsContext = False IsNew = False
					OperandVar369 = "place_ui_cards_list";
					subContext368.SetUiMarker(( (OperandVar369)).ToString());
				}
			}
			Place OperandVar373 = default(Place); //IsContext = False IsNew = False
			UiObject StoredVariable370 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable370 != null)
			{
				UnityEngine.GameObject prop371 = StoredVariable370.ShowedObject; //IsContext = False IsNew = False
				if(prop371 != null)
				{
					Place StoredVariable372 = ((Place)prop371.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable372 != null)
					{
						OperandVar373 = StoredVariable372;
					}
				}
			}
			Place pl =  (OperandVar373); //IsContext = False IsNew = False
			System.String OperandVar374 = default(System.String); //IsContext = False IsNew = False
			OperandVar374 = "place_cards";
			
			{
				UnityEngine.GameObject FuncCtx375 = External.SpawnPrefab(( (OperandVar374)).ToString());; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject FuncCtx375 ContextPropertySwitchInterpreter
				if(FuncCtx375 != null)
				{
					
					{
						AgentsUI subContext376 = (AgentsUI)FuncCtx375.GetComponent(typeof(AgentsUI)); //IsContext = True IsNew = False
						//ContextStatement AgentsUI subContext376 ContextSwitchInterpreter
						if(subContext376 != null)
						{
							Place OperandVar377 = default(Place); //IsContext = False IsNew = False
							OperandVar377 = pl;
							subContext376.TargetPlace = (Place)( (OperandVar377));
						}
					}
					
					{
						CardsHolderAgentsAdapter subContext378 = (CardsHolderAgentsAdapter)FuncCtx375.GetComponent(typeof(CardsHolderAgentsAdapter)); //IsContext = True IsNew = False
						//ContextStatement CardsHolderAgentsAdapter subContext378 ContextSwitchInterpreter
						if(subContext378 != null)
						{
							Place OperandVar379 = default(Place); //IsContext = False IsNew = False
							OperandVar379 = pl;
							subContext378.TargetPlace = (Place)( (OperandVar379));
						}
					}
					UnityEngine.GameObject OperandVar380 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar380 = FuncCtx375;
					UnityEngine.GameObject OperandVar381 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar381 = root;
					External.SetParent((UnityEngine.GameObject)( (OperandVar380)),(UnityEngine.GameObject)( (OperandVar381)));
				}
			}
		}
        }
    }
    
    public class place_ui_size : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar395 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable382 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable382 != null)
			{
				Markers StoredVariable383 = ((Markers)StoredVariable382.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable383 != null)
				{
					System.Boolean ifResult384; //IsContext = False IsNew = False
					
					System.Boolean OperandVar391 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable382 != null)
					{
						UnityEngine.GameObject prop385 = StoredVariable382.ShowedObject; //IsContext = False IsNew = False
						if(prop385 != null)
						{
							System.Boolean ifResult386; //IsContext = False IsNew = False
							System.Boolean OperandVar390 = default(System.Boolean); //IsContext = False IsNew = False
							Place OperandVar388 = default(Place); //IsContext = False IsNew = False
							Place StoredVariable387 = ((Place)prop385.GetComponent(typeof(Place))); //IsContext = False IsNew = False
							if(StoredVariable387 != null)
							{
								OperandVar388 = StoredVariable387;
							}
							System.Boolean prop389 = External.Has( (OperandVar388)); //IsContext = False IsNew = False
							OperandVar390 = prop389;
							if(ifResult386 =  (OperandVar390))
							{
								OperandVar391 = ifResult386;
							}
						}
					}
					
					System.Boolean OperandVar394 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar392 = default(System.String); //IsContext = False IsNew = False
					OperandVar392 = "place_ui_size";
					System.Boolean prop393 = StoredVariable383.HasMarker( (OperandVar392)); //IsContext = False IsNew = False
					OperandVar394 = prop393;
					if(ifResult384 = ( ( (OperandVar391))) && ( (!(OperandVar394))))
					{
						applicable = true;
						OperandVar395 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar395);
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
				Markers subContext396 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext396 ContextSwitchInterpreter
				if(subContext396 != null)
				{
					System.String OperandVar397 = default(System.String); //IsContext = False IsNew = False
					OperandVar397 = "place_ui_size";
					subContext396.SetMarker(( (OperandVar397)).ToString());
				}
			}
			TextField ContextVar398 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement TextField ContextVar398 ContextSwitchInterpreter
				if(ContextVar398 != null)
				{
					
					ContextVar398.Label = (System.String)( ("size"));
					System.Int32 OperandVar403 = default(System.Int32); //IsContext = False IsNew = False
					UiObject StoredVariable399 = ((UiObject)ContextVar398.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
					if(StoredVariable399 != null)
					{
						UnityEngine.GameObject prop400 = StoredVariable399.ShowedObject; //IsContext = False IsNew = False
						if(prop400 != null)
						{
							Place StoredVariable401 = ((Place)prop400.GetComponent(typeof(Place))); //IsContext = False IsNew = False
							if(StoredVariable401 != null)
							{
								System.Int32 prop402 = StoredVariable401.Size; //IsContext = False IsNew = False
								OperandVar403 = prop402;
							}
						}
					}
					ContextVar398.Show(( (OperandVar403)).ToString());
					
					{
						UnityEngine.UI.LayoutElement subContext404 = ContextVar398.Layout; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.UI.LayoutElement subContext404 ContextPropertySwitchInterpreter
						if(subContext404 != null)
						{
							
							subContext404.minHeight = (System.Single)( (20f));
						}
					}
				}
			}
			Entity EntVar405 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar405 != null) EntVar405.ComponentAdded();
		}
        }
    }
}
